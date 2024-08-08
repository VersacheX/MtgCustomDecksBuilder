using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class MtgCard
    {
        public MtgCard()
        {
            MtgCardForeignNames = new HashSet<MtgCardForeignName>();
            MtgCardLegalities = new HashSet<MtgCardLegality>();
            MtgCardRulings = new HashSet<MtgCardRuling>();
            MtgCardSets = new HashSet<MtgCardSet>();
            MtgCardVariations = new HashSet<MtgCardVariation>();
            UserDeckCards = new HashSet<UserDeckCard>();
        }

        public int MtgCardPk { get; set; }
        public string? Artist { get; set; }
        public string? Border { get; set; }
        public decimal? Cmc { get; set; }
        public string? ColorIdentity { get; set; }
        public string? Colors { get; set; }
        public string? Flavor { get; set; }
        public string? Hand { get; set; }
        public string? Id { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsMultiColor { get; set; }
        public bool? IsColorless { get; set; }
        public string? Layout { get; set; }
        public string? Life { get; set; }
        public string? Loyalty { get; set; }
        public string? ManaCost { get; set; }
        public string? MultiverseId { get; set; }
        public string? Name { get; set; }
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

        public virtual ICollection<MtgCardForeignName> MtgCardForeignNames { get; set; }
        public virtual ICollection<MtgCardLegality> MtgCardLegalities { get; set; }
        public virtual ICollection<MtgCardRuling> MtgCardRulings { get; set; }
        public virtual ICollection<MtgCardSet> MtgCardSets { get; set; }
        public virtual ICollection<MtgCardVariation> MtgCardVariations { get; set; }
        public virtual ICollection<UserDeckCard> UserDeckCards { get; set; }
    }
}
