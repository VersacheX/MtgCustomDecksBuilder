using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontProdInfo
    {
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public decimal PriceToStorefront { get; set; }
        public bool DisplayToStorefront { get; set; }
        public bool ProviderAllowDisplayToPublic { get; set; }
        public bool StorefrontDisplayToPublic { get; set; }
        public decimal StdPubPrice { get; set; }
        public decimal CurPubPrice { get; set; }
        public int? ProdPopularityScore { get; set; }
        public decimal? MinAdvertisedPrice { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public int? MaxShoppingCartUnits { get; set; }
        public short? FreeShippingMinQty { get; set; }
        public byte? SearchRelevanceBoost { get; set; }
        public DateTime? LastInfoChangeTimestamp { get; set; }
        public bool? AllowMapinstantCoupon { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
