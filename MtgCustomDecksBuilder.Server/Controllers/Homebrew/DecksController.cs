using BObj.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Schema;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class DecksController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;
        private readonly IMemoryCache _cache;

        public DecksController(MtgCustomDecksBuilderContext masterContext, IMemoryCache cache)
        {
            _masterContext = masterContext;
            _cache = cache;
        }

        [HttpPost]
        public async Task<IActionResult> Import(DeckImportData data)
        {
            List<MtgCardDto> deckList = new List<MtgCardDto>();
            if (!string.IsNullOrWhiteSpace(data.DeckList))
            {
                string[] rows = data.DeckList.Split('\n');

                foreach(string row in rows) {
                    string countString = row.Substring(0, row.IndexOf(" "));
                    string rowString = row.Substring(row.IndexOf(" ") + 1);

                    string cardName = rowString.Substring(0, rowString.IndexOf("(") - 1);
                    rowString = rowString.Substring(rowString.IndexOf("(") + 1);

                    string cardSet = rowString.Substring(0, rowString.IndexOf(")"));

                    rowString = rowString.Substring(rowString.IndexOf(")") +2);
                    if (rowString.IndexOf(" ") > 0)
                        rowString = rowString.Substring(0, rowString.IndexOf(" "));
                    string cardNumber = rowString;

                    try
                    {
                        // Retrieve cached data
                        if (!_cache.TryGetValue("MtgCardsCache", out List<MtgCard> cachedMtgCards))
                        {
                            return BadRequest("Cache not found");
                        }

                        var card =
                            cachedMtgCards
                                .FirstOrDefault(x => x.Name == cardName && x.Set == cardSet && x.Number == cardNumber);

                        if (card == null)
                        {
                            card = cachedMtgCards
                                .FirstOrDefault(x => x.Name == cardName);
                        }

                        if (card == null)
                            continue;

                        var mtgCardDto = MtgCardDto.FromEntity(card);

                        int cardCount = int.Parse(countString);
                        for (int i = 0; i < cardCount; i++)
                            deckList.Add(mtgCardDto);
                    }
                    catch (Exception e)
                    {
                        return BadRequest(e.Message);
                    }
                }
            }
            return Ok(deckList);
        }
    }

    public class DeckImportData
    {
        public string? DeckList { get; set; }
    }

}
