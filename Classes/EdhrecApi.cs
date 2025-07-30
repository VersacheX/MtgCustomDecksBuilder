using BObj.Dto;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Schema;
using System.Net;
using System.Web;

namespace Bobj
{
    public static class EdhrecApi
    {
        public static async Task<EdhrecDto> SourceEdhRecData(EdhrecSearchCriteria criteria, IMemoryCache cache)
        {
            //string url = $"https://edhrec.com/commanders/{criteria.CommanderName.ToLower().Replace(" ", "-").Replace(",", "")}{commander2}";

            var cardsAlreadyInDeck = criteria.MtgCards?.Select(x => x.Name).ToArray() ?? Array.Empty<string>();
            string commander = criteria.CommanderName.ToLower();
            if (commander.Contains(" // "))
                commander = commander.Substring(0, commander.IndexOf(" // "));


            string commander2 = string.Empty;
            if (!string.IsNullOrWhiteSpace(criteria.CommanderName2))
            {
                commander2 = criteria.CommanderName2.ToLower();
                if (commander2.Contains(" // "))
                    commander2 = commander2.Substring(0, commander2.IndexOf(" // "));

                commander2 = "-" + commander2.Replace(" ", "-").Replace(",", "");
            }


            // Base URL and fixed parts
            var baseUrl = $"https://edhrec.com/commanders/{commander.ToLower().Replace(" ", "-").Replace(",", "")}{commander2}";


            //var queryPrefix = "?f=in%3D";
            //var maxUrlLength = 2048; // Adjust this based on your needs

            //// Calculate the remaining length available for card names
            //var remainingLength = maxUrlLength - baseUrl.Length - queryPrefix.Length;

            //// Initialize the query parameter
            //var queryParameter = queryPrefix;
            //foreach (var card in cardsAlreadyInDeck)
            //{
            //    var encodedCard = HttpUtility.UrlEncode(card);
            //    var potentialQuery = queryParameter + (queryParameter == queryPrefix ? "" : ";in%3D") + encodedCard;

            //    if (baseUrl.Length + potentialQuery.Length > maxUrlLength)
            //    {
            //        break; // Stop adding cards if the maximum length is exceeded
            //    }

            //    queryParameter = potentialQuery;
            //}



            string[] nodeIds = EdhrecDto.EDHREC_NODE_IDS;
            var url = baseUrl;// + queryParameter;

            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(30);
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    HtmlDocument document = new HtmlDocument();
                    document.LoadHtml(responseBody);

                    EdhrecDto dto = InitializeEdhrecDto();

                    ExtractCardNames(document, nodeIds, dto);

                    var almostIncludedCardNames = dto.EdhrecCardGroupLists.SelectMany(group => group.Value).Distinct().ToList();
                    cardsAlreadyInDeck = criteria.MtgCards?.Select(x => x.Name).ToArray() ?? Array.Empty<string>();

                    var resValue = PopulateMtgCardLists(dto, cache, criteria.Homebrew, almostIncludedCardNames, cardsAlreadyInDeck);
                    return resValue;

                }
                catch (HttpRequestException e)
                {
                    throw new Exception(e.Message);
                }
                catch (TaskCanceledException e)
                {
                    throw new Exception("Request timed out.");
                }
                catch (Exception e)
                {
                    throw new Exception("An unexpected error occurred.");
                }
            }

        }

        private static void ExtractCardNames(HtmlDocument document, string[] nodeIds, EdhrecDto dto)
        {
            foreach (var nodeId in nodeIds)
            {
                var node = document.GetElementbyId(nodeId);
                if (node != null)
                {
                    var cardNameNodes = node.SelectNodes(".//span[@class='Card_name__Mpa7S']");
                    if (cardNameNodes != null)
                    {
                        foreach (var cardNameNode in cardNameNodes)
                        {
                            string decodedCardName = WebUtility.HtmlDecode(cardNameNode.InnerText);
                            dto.EdhrecCardGroupLists[nodeId].Add(decodedCardName);
                        }
                    }

                    var usageNodes = node.SelectNodes(".//div[@class='CardLabel_label__iAM7T']");
                    if (usageNodes != null)
                    {
                        if (dto.EdhrecPercentInUserDeckLists == null)
                            dto.EdhrecPercentInUserDeckLists = new Dictionary<string, List<string>>();

                        foreach (var usageNode in usageNodes)
                        {
                            string usageText = WebUtility.HtmlDecode(usageNode.InnerText);
                            if (!dto.EdhrecPercentInUserDeckLists.ContainsKey(nodeId))                            
                                dto.EdhrecPercentInUserDeckLists[nodeId] = new List<string>();

                            dto.EdhrecPercentInUserDeckLists[nodeId].Add(usageText);
                        }
                    }
                }
            }
        }

        private static EdhrecDto PopulateMtgCardLists(EdhrecDto dto, IMemoryCache cache, HomebrewDto homebrew, List<string> almostIncludedCardNames, string[] cardsAlreadyInDeck)
        {
            dto.MtgCardGroupLists = new Dictionary<string, List<MtgCard>>();

            // Retrieve cached data
            if (!cache.TryGetValue("MtgCardsCache", out List<MtgCard> cachedMtgCards))
            {
                throw new Exception("Cards not in cache!");
            }

            // Filter the cached data based on criteria
            var query = cachedMtgCards.AsQueryable();

            foreach (var group in dto.EdhrecCardGroupLists)
            {
                var mtgCardList = cachedMtgCards
                    .Where(card => group.Value.Contains(card.Name) && almostIncludedCardNames.Contains(card.Name))
                    .GroupBy(card => card.Name)
                    .Select(group => group.First())
                    .AsEnumerable() // Make the collection enumerable
                    .Where(card => !cardsAlreadyInDeck.Contains(card.Name)) // Filter out cards already in deck
                    .Where(card => IsCardLegal(card, homebrew)) // Apply IsCardLegal filter
                    .ToList();

                dto.MtgCardGroupLists[group.Key] = mtgCardList;
            }

            return dto;
        }

        private static bool IsCardLegal(MtgCard card, DeckRuleCriterion homebrew)
        {
            if (homebrew == null)
            {
                return true;
            }

            var homebrewDto = HomebrewDto.FromEntity(homebrew);
            return homebrewDto.IsCardLegal(card);
        }

        private static bool IsCardLegal(MtgCard card, HomebrewDto homebrew)
        {
            if (homebrew == null)
            {
                return true;
            }

            //var homebrewDto = HomebrewDto.FromEntity(homebrew);
            return homebrew.IsCardLegal(card);
        }

        private static EdhrecDto InitializeEdhrecDto()
        {
            return new EdhrecDto
            {
                EdhrecCardGroupLists = new Dictionary<string, List<string>>
                        {
                            { "newcards", new List<string>() },
                            { "highsynergycards", new List<string>() },
                            { "topcards", new List<string>() },
                            { "creatures", new List<string>() },
                            { "instants", new List<string>() },
                            { "sorceries", new List<string>() },
                            { "utilityartifacts", new List<string>() },
                            { "enchantments", new List<string>() },
                            { "planeswalkers", new List<string>() },
                            { "utilitylands", new List<string>() },
                            { "manaartifacts", new List<string>() },
                            { "lands", new List<string>() }
                        }
            };
        }



        public class EdhrecSearchCriteria
        {
            public string? CommanderName { get; set; }
            public string? CommanderName2 { get; set; }
            public HomebrewDto? Homebrew { get; set; }
            public List<MtgCardDto>? MtgCards { get; set; }
        }
    }
}
