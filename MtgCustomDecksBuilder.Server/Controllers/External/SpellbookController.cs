using BObj.Dto;
using BObj.External;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.OpenApi.Extensions;
using Persistence.Schema;
using System.Data;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class SpellbookController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;
        private readonly IMemoryCache _cache;

        public SpellbookController(MtgCustomDecksBuilderContext masterContext, IMemoryCache cache)
        {
            _masterContext = masterContext;
            _cache = cache;
        }

        [HttpPost]
        public async Task<IActionResult> GetIncludedCombos(SpellbookSearchCriteria criteria)
        {
            List<ComboDto> resultList = new List<ComboDto>();
            var cardsAlreadyInDeck = criteria.MtgCards.Select(x => new { card = x.Name, quantity = 1 }).ToArray();

            using (var client = new HttpClient())
            {
                AddSpellbookHeaders(client);

                var jsonData = new
                {
                    commanders = new object[] { },
                    main = cardsAlreadyInDeck
                };
                string jsonString = JsonSerializer.Serialize(jsonData);

                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync("https://backend.commanderspellbook.com/find-my-combos", content);
                var responseString = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseString))
                {
                    JsonElement root = doc.RootElement;
                    JsonElement results = root.GetProperty("results");
                    JsonElement includedArray = results.GetProperty("included");

                    var includedList = JsonSerializer.Deserialize<List<Included>>(includedArray.GetRawText());

                    if (includedList == null)
                    {
                        throw new Exception("Failed to parse the included array.");
                    }

                    var uniqueCardNames = includedList
                            .SelectMany(root => root.Uses)
                            .Select(use => use.Card.Name)
                            .Distinct()
                            .ToList();

                    // Retrieve cached data
                    if (!_cache.TryGetValue("MtgCardsCache", out List<MtgCard> cachedMtgCards))
                    {
                        return BadRequest("Cache not found");
                    }

                    resultList = includedList.Select(include => new ComboDto
                                            {
                                                IncludeId = include.Id,
                                                Cards = cachedMtgCards
                                                    .Where(card => include.Uses.Any(use => use.Card.Name == card.Name))
                                                    .GroupBy(card => card.Name)
                                                    .Select(group => MtgCardDto.FromEntity(group.First(), _cache))
                                                    .ToList()
                                            }).OrderBy(combo => combo.Cards.Count)
                                            .ToList();


                }
            }

            return Ok(resultList);
        }

        [HttpPost]
        public async Task<IActionResult> GetSuggestedCardsByCriteria(SpellbookSearchCriteria criteria)
        {
            List<ComboDto> returnData = new List<ComboDto>();
            var cardsAlreadyInDeck = criteria.MtgCards.Select(x => new { card = x.Name, quantity = 1 }).ToArray();
            var cardNamesInDeck = cardsAlreadyInDeck.Select(x => x.card).ToList();

            using (var client = new HttpClient())
            {
                AddSpellbookHeaders(client);

                var jsonData = new
                {
                    commanders = new object[] { },
                    main = cardsAlreadyInDeck
                };
                string jsonString = JsonSerializer.Serialize(jsonData);

                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync("https://backend.commanderspellbook.com/find-my-combos", content);
                var responseString = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseString))
                {
                    #region Get included and almost included sections of Spellbook results
                    JsonElement root = doc.RootElement;
                    JsonElement results = root.GetProperty("results");

                    JsonElement almostIncludedArray = results.GetProperty("almostIncluded");
                    var almostIncludedList = JsonSerializer.Deserialize<List<Included>>(almostIncludedArray.GetRawText());
                    if (almostIncludedList == null)
                    {
                        throw new Exception("Failed to parse the almost Included array.");
                    }
                    #endregion

                    //Get Distinct cards from the list
                    var almostIncludedCardNames = almostIncludedList
                        .SelectMany(included => included.Uses.Select(use => use.Card.Name))
                        .Distinct()
                        .ToList();

                    // Retrieve cached data
                    if (!_cache.TryGetValue("MtgCardsCache", out List<MtgCard> cachedMtgCards))
                    {
                        return BadRequest("Cache not found");
                    }

                    /////////////////////////////////////////////////////////////////////////////
                    // Step 2: Perform the complex filtering in-memory
                    var distinctMtgCards = cachedMtgCards
                        .Where(card => almostIncludedCardNames.Contains(card.Name))
                        .GroupBy(card => card.Name)
                        .Select(group => MtgCardDto.FromEntity(group.First(), _cache))
                        .ToList();


                    // Step 3: Further filter the cards as needed
                    List<MtgCardDto> legalCards = distinctMtgCards
                        .Where(card => !cardNamesInDeck.Contains(card.Name))
                        .ToList();

                    if (criteria.Homebrew != null)
                        legalCards = legalCards
                            .Where(criteria.Homebrew.IsCardLegal)
                            .ToList();

                    legalCards.AddRange(criteria.MtgCards);

                    foreach (var included in almostIncludedList)
                    {
                        // Check if all cards in Uses are in legalCards
                        if (included.Uses != null && included.Uses.All(use => legalCards.Any(card => card.Name == use.Card.Name)))
                        {
                            // Create a list of MtgCardDto for this Included object
                            var cardList = included.Uses
                                .Select(use => legalCards.First(card => card.Name == use.Card.Name))
                                .ToList();

                            returnData.Add(new ComboDto()
                            {
                                IncludeId = included.Id,
                                Cards = cardList
                            });
                        }
                    }

                    returnData = returnData.OrderBy(combo => combo.Cards.Count)
                                            .ToList();
                }
            }

            return Ok(returnData);
        }

        static HttpClient AddSpellbookHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.9");
            client.DefaultRequestHeaders.Add("origin", "https://commanderspellbook.com");
            client.DefaultRequestHeaders.Add("priority", "u=1, i");
            client.DefaultRequestHeaders.Add("referer", "https://commanderspellbook.com/");
            client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Not)A;Brand\";v=\"99\", \"Microsoft Edge\";v=\"127\", \"Chromium\";v=\"127\"");
            client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
            client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
            client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
            client.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
            client.DefaultRequestHeaders.Add("sec-fetch-site", "same-site");
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/127.0.0.0 Safari/537.36 Edg/127.0.0.0");

            return client;
        }
    }

    public class SpellbookSearchCriteria
    {
        public HomebrewDto? Homebrew { get; set; }
        public List<MtgCardDto>? MtgCards { get; set; }
    }

}
