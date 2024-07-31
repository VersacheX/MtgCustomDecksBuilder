using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CartsWholesaleOrder
    {
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public int Qty { get; set; }
        public decimal? EffectiveWhlsPrice { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
