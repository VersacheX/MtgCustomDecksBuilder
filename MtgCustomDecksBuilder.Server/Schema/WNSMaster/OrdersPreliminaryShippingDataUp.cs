using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersPreliminaryShippingDataUp
    {
        public int ProviderOrderId { get; set; }
        public string WrhsName { get; set; } = null!;
        public byte? Zone { get; set; }
        public byte? TransitTime { get; set; }
        public decimal? Cost { get; set; }
        public decimal? ProviderCostSubtotal { get; set; }
        public decimal? Weight { get; set; }
    }
}
