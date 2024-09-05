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
        public async Task<IActionResult> GetUserDecks(GetUserDecksCriteria criteria)
        {
            List<UserDeck> decks = await _masterContext.UserDecks.ToListAsync();

            return Ok(decks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            UserDeck deck = await _masterContext.UserDecks
                                    .Include(deck=>deck.UserDeckCards).FirstOrDefaultAsync(x => x.UserDeckPk == id);

            if (deck == null)
            {
                return BadRequest("Somebody jacked your deck");
            }

            UserDeckDto userDeck = UserDeckDto.FromEntity(deck);

            // Retrieve cached data
            if (!_cache.TryGetValue("MtgCardsCache", out List<MtgCard> cachedMtgCards))
            {
                return BadRequest("Cache not found");
            }

            List<MtgCardDto>? deckList = cachedMtgCards
                                .Where(card => deck.UserDeckCards.Any(dc => dc.MtgCardFk == card.MtgCardPk))
                                .Select(MtgCardDto.FromEntity)
                                .ToList();

            List<int?> commanderIds = new List<int?>();
            commanderIds = deck.UserDeckCards.Where(x => x.IsCommander == true).Select(x=>x.MtgCardFk).ToList();

            int? companionId = deck.UserDeckCards.FirstOrDefault(x => x.IsCompanion == true)?.MtgCardFk;

            MtgCardDto?[] commanders = new MtgCardDto?[2] { null, null };
            MtgCardDto? companion = null;

            if(companionId > 0)
            {
                companion = deckList.FirstOrDefault(x => x.Id == companionId);
            }

            for(int i = 0; i < commanderIds.Count; i++)
            {
                commanders[i] = deckList.FirstOrDefault(x => x.Id == commanderIds[i]);
            }

            if(deck.DeckRuleCriteriaFk != null)
            {
                DeckRuleCriterion criteron = _masterContext.DeckRuleCriteria
                    .Include(x => x.GameFormatFkNavigation)
                    .Include(x => x.MtgFormatFkNavigation)
                    .Include(x => x.DeckRuleCriteriaAllowedSets)
                        .ThenInclude(x => x.MtgSetFkNavigation)
                    .Include(x => x.DeckRuleCriteriaSetTypes)
                        .ThenInclude(x => x.SetTypeFkNavigation)
                    .FirstOrDefault(x => x.DeckRuleCriterionPk == deck.DeckRuleCriteriaFk);

                if(criteron != null)
                {
                    userDeck.Homebrew = HomebrewDto.FromEntity(criteron);
                }
                
            }

            userDeck.Commander1 = commanders[0];
            userDeck.Commander2 = commanders[1];
            userDeck.Companion = companion;
            userDeck.DeckList = deckList.ToArray();            

            return Ok(userDeck);
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

        [HttpPost]
        public async Task<IActionResult> Save(SaveDeckCriteria criteria)
        {
            try
            {
                if (criteria.DeckList == null || criteria.DeckList.Length < 1)
                    return BadRequest("A deck has to have cards in it");

                criteria.DeckList = RemoveCommanderAndCompanion(criteria.DeckList, criteria.Commander1, criteria.Commander2, criteria.Companion);

                if (criteria.Id > 0)
                {
                    await UpdateDeck(criteria);
                }
                else
                {
                    await CreateNewDeck(criteria);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

        private MtgCardDto[] RemoveCommanderAndCompanion(MtgCardDto[] deckList, params MtgCardDto[] cardsToRemove)
        {
            foreach (var card in cardsToRemove)
            {
                if (card != null)
                {
                    deckList = RemoveFirstOccurrence(deckList, card.Name);
                }
            }
            return deckList;
        }

        private async Task CreateNewDeck(SaveDeckCriteria criteria)
        {
            var userDeck = new UserDeck
            {
                DeckName = criteria.Name,
                UserFk = GetUserId(),
                DeckRuleCriteriaFk = criteria.Homebrew?.Id
            };

            var cards = new List<UserDeckCard>();

            AddCardIfNotNull(cards, criteria.Commander1, true, false);
            AddCardIfNotNull(cards, criteria.Commander2, true, false);
            AddCardIfNotNull(cards, criteria.Companion, false, true);

            foreach (var deckCard in criteria.DeckList)
            {
                cards.Add(new UserDeckCard
                {
                    DeckLocationFk = 1, // Library
                    MtgCardFk = deckCard.Id
                });
            }

            userDeck.UserDeckCards = cards;

            // Clear the change tracker to avoid tracking issues
            _masterContext.ChangeTracker.Clear();

            _masterContext.UserDecks.Add(userDeck);
            await _masterContext.SaveChangesAsync();
        }

        private void AddCardIfNotNull(List<UserDeckCard> cards, MtgCardDto cardDto, bool isCommander, bool isCompanion)
        {
            if (cardDto != null)
            {
                cards.Add(new UserDeckCard
                {
                    IsCommander = isCommander,
                    IsCompanion = isCompanion,
                    DeckLocationFk = 1, // Library
                    MtgCardFk = cardDto.Id
                });
            }
        }

        private async Task<IActionResult> UpdateDeck(SaveDeckCriteria criteria)
        {
            try
            {
                var userId = GetUserId();
                var userDeck = await _masterContext.UserDecks
                    .Include(ud => ud.UserDeckCards)
                    .FirstOrDefaultAsync(ud => ud.UserDeckPk == criteria.Id);

                if (userDeck == null)
                {
                    return NotFound("Deck not found.");
                }

                if (userDeck.UserFk != userId)
                {
                    return Forbid("You are not authorized to update this deck.");
                }

                // Remove all existing UserDeckCards
                _masterContext.UserDeckCards.RemoveRange(userDeck.UserDeckCards);

                // Update deck details
                userDeck.DeckName = criteria.Name;
                userDeck.DeckRuleCriteriaFk = criteria.Homebrew?.Id;

                var cards = new List<UserDeckCard>();

                AddCardIfNotNull(cards, criteria.Commander1, true, false);
                AddCardIfNotNull(cards, criteria.Commander2, true, false);
                AddCardIfNotNull(cards, criteria.Companion, false, true);

                foreach (var deckCard in criteria.DeckList)
                {
                    cards.Add(new UserDeckCard
                    {
                        DeckLocationFk = 1, // Library
                        MtgCardFk = deckCard.Id
                    });
                }

                userDeck.UserDeckCards = cards;

                await _masterContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

        private MtgCardDto[] RemoveFirstOccurrence(MtgCardDto[] deckList, string cardName)
        {
            var index = Array.FindIndex(deckList, card => card.Name == cardName);
            if (index >= 0)
            {
                var list = deckList.ToList();
                list.RemoveAt(index);
                return list.ToArray();
            }
            return deckList;
        }
    }

    public class GetUserDecksCriteria
    {

    }

    public class SaveDeckCriteria
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public MtgCardDto? Commander1 { get; set; }
        public MtgCardDto? Commander2 { get; set; }
        public MtgCardDto? Companion {  get; set; }
        public HomebrewDto? Homebrew { get; set; }
        public MtgCardDto[]? DeckList { get; set; }
    }

    public class DeckImportData
    {
        public string? DeckList { get; set; }
    }

}
