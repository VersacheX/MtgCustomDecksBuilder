using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class ScryfallCard
    {
        public ScryfallCard()
        {
            ScryfallCardImageUris = new HashSet<ScryfallCardImageUri>();
            ScryfallCardLegalities = new HashSet<ScryfallCardLegality>();
            ScryfallCardPrices = new HashSet<ScryfallCardPrice>();
            ScryfallCardPurchaseUris = new HashSet<ScryfallCardPurchaseUri>();
            ScryfallCardRelatedUris = new HashSet<ScryfallCardRelatedUri>();
        }

        public int ScryfallCardPk { get; set; }
        public string? Object { get; set; }
        public string? Id { get; set; }
        public string? OracleId { get; set; }
        public string? MultiverseIds { get; set; }
        public int? MtgoId { get; set; }
        public int? ArenaId { get; set; }
        public int? TcgplayerId { get; set; }
        public string? Name { get; set; }
        public string? Lang { get; set; }
        public DateTime? ReleasedAt { get; set; }
        public string? Uri { get; set; }
        public string? ScryfallUri { get; set; }
        public string? Layout { get; set; }
        public bool? HighresImage { get; set; }
        public string? ImageStatus { get; set; }
        public string? ManaCost { get; set; }
        public double? Cmc { get; set; }
        public string? TypeLine { get; set; }
        public string? OracleText { get; set; }
        public string? Colors { get; set; }
        public string? ColorIdentity { get; set; }
        public string? ProducedMana { get; set; }
        public string? Games { get; set; }
        public bool? Reserved { get; set; }
        public bool? GameChanger { get; set; }
        public bool? Foil { get; set; }
        public bool? Nonfoil { get; set; }
        public string? Finishes { get; set; }
        public bool? Oversized { get; set; }
        public bool? Promo { get; set; }
        public bool? Reprint { get; set; }
        public bool? Variation { get; set; }
        public string? SetId { get; set; }
        public string? Set { get; set; }
        public string? SetName { get; set; }
        public string? SetType { get; set; }
        public string? SetUri { get; set; }
        public string? SetSearchUri { get; set; }
        public string? ScryfallSetUri { get; set; }
        public string? RulingsUri { get; set; }
        public string? PrintsSearchUri { get; set; }
        public string? CollectorNumber { get; set; }
        public bool? Digital { get; set; }
        public string? Rarity { get; set; }
        public string? CardBackId { get; set; }
        public string? Artist { get; set; }
        public string? ArtistIds { get; set; }
        public string? IllustrationId { get; set; }
        public string? BorderColor { get; set; }
        public string? Frame { get; set; }
        public bool? FullArt { get; set; }
        public bool? Textless { get; set; }
        public bool? Booster { get; set; }
        public bool? StorySpotlight { get; set; }

        public virtual ICollection<ScryfallCardImageUri> ScryfallCardImageUris { get; set; }
        public virtual ICollection<ScryfallCardLegality> ScryfallCardLegalities { get; set; }
        public virtual ICollection<ScryfallCardPrice> ScryfallCardPrices { get; set; }
        public virtual ICollection<ScryfallCardPurchaseUri> ScryfallCardPurchaseUris { get; set; }
        public virtual ICollection<ScryfallCardRelatedUri> ScryfallCardRelatedUris { get; set; }
    }
}
