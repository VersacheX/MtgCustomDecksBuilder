using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Aporderdetail
    {
        public short? StorefrontId { get; set; }
        public int? ProviderOrderId { get; set; }
        public short? Qty { get; set; }
        public decimal? PriceToStorefront { get; set; }
    }
}
