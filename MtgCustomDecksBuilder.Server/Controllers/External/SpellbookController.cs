using BObj.Dto;
using BObj.External;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Schema;
using System.Data;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

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
        public async Task<IActionResult> GetSuggestedCardsByCriteria(SpellbookSearchCriteria criteria)
        {
            List<MtgCardDto> legalCards = new List<MtgCardDto>();
            string[] cardsAlreadyInDeck = criteria.MtgCards.Select(x=>x.Name).ToArray();

            using (var client = new HttpClient())
            {
                AddSpellbookHeaders(client);

                var jsonData = new
                {
                    commanders = new string[] { },
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
                    JsonElement includedArray = results.GetProperty("included");

                    var includedList = JsonSerializer.Deserialize<List<Included>>(includedArray.GetRawText());

                    if (includedList == null)
                    {
                        throw new Exception("Failed to parse the included array.");
                    }

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
                        //_masterContext.MtgCards
                        //.Include(card => card.MtgCardLegalities)
                        //.Include(card => card.MtgCardSets)
                        //    .ThenInclude(cardSet => cardSet.MtgSetFkNavigation)
                        .Where(card => almostIncludedCardNames.Contains(card.Name))
                        .GroupBy(card => card.Name)
                        .Select(group => MtgCardDto.FromEntity(group.First()))
                        .ToList();


                    // Step 3: Further filter the cards as needed
                    legalCards = distinctMtgCards
                        .Where(card => !cardsAlreadyInDeck.Contains(card.Name))
                        .ToList();

                    if(criteria.Homebrew != null)
                        legalCards = legalCards
                            .Where(criteria.Homebrew.IsCardLegal)
                            .ToList();
                }
            }

            return Ok(legalCards);
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
