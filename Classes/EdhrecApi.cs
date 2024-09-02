using BObj.Dto;
using HtmlAgilityPack;
using Microsoft.EntityFrameworkCore;
using Persistence.Schema;
using System.Net;

namespace Bobj
{
    public static class EdhrecApi
    {
        public static async Task<EdhrecDto> SourceEdhRecData(EdhrecSearchCriteria criteria, MtgCustomDecksBuilderContext _masterContext)
        {
            string commander2 = !string.IsNullOrWhiteSpace(criteria.CommanderName2) ? "-" + criteria.CommanderName2.ToLower().Replace(" ", "-").Replace(",", "") : "";
            string url = $"https://edhrec.com/commanders/{criteria.CommanderName.ToLower().Replace(" ", "-").Replace(",", "")}{commander2}";
            string[] nodeIds = EdhrecDto.EDHREC_NODE_IDS;

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
                    var cardsAlreadyInDeck = criteria.MtgCards?.Select(x => x.Name).ToArray() ?? Array.Empty<string>();

                    return PopulateMtgCardLists(dto, _masterContext, criteria.Homebrew, almostIncludedCardNames, cardsAlreadyInDeck);

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
                }
            }
        }

        private static EdhrecDto PopulateMtgCardLists(EdhrecDto dto, MtgCustomDecksBuilderContext _masterContext, DeckRuleCriterion homebrew, List<string> almostIncludedCardNames, string[] cardsAlreadyInDeck)
        {
            dto.MtgCardGroupLists = new Dictionary<string, List<MtgCard>>();

            foreach (var group in dto.EdhrecCardGroupLists)
            {
                var mtgCardList = _masterContext.MtgCards
                    .Include(card => card.MtgCardLegalities)
                    .Include(card => card.MtgCardSets)
                        .ThenInclude(cardSet => cardSet.MtgSetFkNavigation)
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
            return homebrewDto.IsCardLegal(MtgCardDto.FromEntity(card));
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
            public DeckRuleCriterion? Homebrew { get; set; }
            public List<MtgCardDto>? MtgCards { get; set; }
        }
    }
}
