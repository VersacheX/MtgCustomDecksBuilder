using BObj.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.Schema;

namespace MtgCustomDecksBuilder.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Authorize]
    public class DecksController : BaseController
    {
        private readonly MtgCustomDecksBuilderContext _masterContext;

        public DecksController(MtgCustomDecksBuilderContext masterContext)
        {
            _masterContext = masterContext;
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
                        var card = _masterContext.MtgCards
                                .Include(x => x.MtgCardLegalities)
                                .Include(x => x.MtgCardSets)
                                .ThenInclude(y => y.MtgSetFkNavigation)
                                .FirstOrDefault(x => x.Name == cardName && x.Set == cardSet && x.Number == cardNumber);

                        if (card == null)
                        {
                            card = _masterContext.MtgCards
                                .Include(x => x.MtgCardLegalities)
                                .Include(x => x.MtgCardSets)
                                .ThenInclude(y => y.MtgSetFkNavigation)
                                .FirstOrDefault(x => x.Name == cardName);
                        }

                        if (card == null)
                            continue;

                        var mtgCardDto = new MtgCardDto
                        {
                            Id = card.MtgCardPk,
                            Name = card.Name,
                            ImageUrl = card.ImageUrl,
                            Flavor = card.Flavor,
                            Artist = card.Artist,
                            Border = card.Border,
                            Cmc = card.Cmc,
                            ColorIdentity = card.ColorIdentity,
                            Colors = card.Colors,
                            Hand = card.Hand,
                            IsMultiColor = card.IsMultiColor,
                            IsColorless = card.IsColorless,
                            Layout = card.Layout,
                            Life = card.Life,
                            Loyalty = card.Loyalty,
                            ManaCost = card.ManaCost,
                            MultiverseId = card.MultiverseId,
                            Names = card.Names,
                            Number = card.Number,
                            OriginalText = card.OriginalText,
                            OriginalType = card.OriginalType,
                            Power = card.Power,
                            Printings = card.Printings,
                            Rarity = card.Rarity,
                            ReleaseDate = card.ReleaseDate,
                            Reserved = card.Reserved,
                            Set = card.Set,
                            SetName = card.SetName,
                            Source = card.Source,
                            Starter = card.Starter,
                            SubTypes = card.SubTypes,
                            SuperTypes = card.SuperTypes,
                            Text = card.Text,
                            Timeshifted = card.Timeshifted,
                            Toughness = card.Toughness,
                            Type = card.Type,
                            Types = card.Types,
                            Watermark = card.Watermark,
                            MtgCardLegalities = card.MtgCardLegalities.Select(legality => new MtgCardLegalityDto
                            {
                                Id = legality.MtgCardLegalityPk,
                                Format = legality.Format,
                                Legality = legality.Legality
                            }).ToList(),
                            MtgCardSets = card.MtgCardSets.Select(set => new MtgCardSetDto
                            {
                                Id = set.MtgCardSetPk,
                                SetName = set.MtgSetFkNavigation.Name,
                                SetType = set.MtgSetFkNavigation.Type,
                                MtgSetFk = set.MtgSetFk
                            }).ToList()
                        };

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
