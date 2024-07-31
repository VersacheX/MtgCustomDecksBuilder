using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CartsStorefrontOrder
    {
        public string SessionId { get; set; } = null!;
        public short LineNum { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public int Qty { get; set; }
        public string? BrandDesc { get; set; }
        public string? ProdName { get; set; }
        public decimal? UnitNum { get; set; }
        public string? UnitTypeDesc { get; set; }
        public decimal? Msrp { get; set; }
        public decimal? PriceToConsumer { get; set; }
        public string? StorefrontSku { get; set; }
        public decimal? TaxPercent { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
