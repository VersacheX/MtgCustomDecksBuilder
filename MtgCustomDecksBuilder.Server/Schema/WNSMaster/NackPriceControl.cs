using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class NackPriceControl
    {
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public decimal? MarkupPercent { get; set; }
        public bool? HideFromSf { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
