using BObj.Scryfall;
using Microsoft.Extensions.Caching.Memory;
using Persistence.Schema;

namespace BObj.Dto
{
    public class MtgCardDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? Flavor { get; set; }
        public string? Artist { get; set; }
        public string? Border { get; set; }
        public decimal? Cmc { get; set; }
        public string? ColorIdentity { get; set; }
        public string? Colors { get; set; }
        public string? Hand { get; set; }
        public bool? IsMultiColor { get; set; }
        public bool? IsColorless { get; set; }
        public string? Layout { get; set; }
        public string? Life { get; set; }
        public string? Loyalty { get; set; }
        public string? ManaCost { get; set; }
        public string? MultiverseId { get; set; }
        public string? Names { get; set; }
        public string? Number { get; set; }
        public string? OriginalText { get; set; }
        public string? OriginalType { get; set; }
        public string? Power { get; set; }
        public string? Printings { get; set; }
        public string? Rarity { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool? Reserved { get; set; }
        public string? Set { get; set; }
        public string? SetName { get; set; }
        public string? Source { get; set; }
        public bool? Starter { get; set; }
        public string? SubTypes { get; set; }
        public string? SuperTypes { get; set; }
        public string? Text { get; set; }
        public bool? Timeshifted { get; set; }
        public string? Toughness { get; set; }
        public string? Type { get; set; }
        public string? Types { get; set; }
        public string? Watermark { get; set; }
        public ICollection<MtgCardLegalityDto>? MtgCardLegalities { get; set; }
        public ICollection<MtgCardSetDto>? MtgCardSets { get; set; }

        public string? EdhrecIncludeStats { get; set; }
        public decimal? TcgPlayerMarketValue { get; set; }

        public string? MtgCardId { get; set; }

        public static MtgCardDto FromEntity(MtgCard card, IMemoryCache cache)
        {
            return new MtgCardDto
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
                MtgCardId = card.Id,
                TcgPlayerMarketValue = SetTcgPlayerMarketValue(card, cache),
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
        }
        
        private static decimal? SetTcgPlayerMarketValue(MtgCard card, IMemoryCache cache)
        {
            decimal? resVal = null;
            if (cache.TryGetValue("CardData", out List<ScryfallCardDto> cachedScryfallCards))
            {
                ScryfallCardDto[] possibleCards = cachedScryfallCards.Where(x => x.Name.ToLower() == card.Name.ToLower() && x.Set.ToLower() == card.Set.ToLower()).ToArray();

                if (possibleCards.Length == 1)
                {
                    if (possibleCards[0]?.Prices?.Usd != null)
                        resVal = decimal.Parse(possibleCards[0].Prices.Usd);
                }
                else if (possibleCards.Length > 1)
                {
                    ScryfallCardDto scryfallCard = possibleCards.Where(x => x.Artist == card.Artist).FirstOrDefault();
                    if (scryfallCard?.Prices?.Usd != null)
                    {
                        resVal = decimal.Parse(scryfallCard.Prices.Usd);
                    }

                }
            }

            return resVal;
        }
    }

    public class MtgCardLegalityDto
    {
        public int Id { get; set; }
        public string? Format { get; set; }
        public string? Legality { get; set; }
    }

    public class MtgCardSetDto
    {
        public int Id { get; set; }
        public string? SetName { get; set; }
        public string? SetType { get; set; }
        public int? MtgSetFk { get; set; }
    }
}
