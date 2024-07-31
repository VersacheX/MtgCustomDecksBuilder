using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TempWorkingProdsShippingCost
    {
        public string Asin { get; set; } = null!;
        public int? ProdId { get; set; }
        public bool? CantShipInEnvelope { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? EstimatedShippingWeightOz { get; set; }
        public decimal? EstimatedShippingWeightOzRounded { get; set; }
        public decimal? ActualShippingWeightOz { get; set; }
        public decimal? ActualShippingWeightOzRounded { get; set; }
        public decimal? EconomyShippingCost { get; set; }
        public decimal? StandardShippingCost { get; set; }
        public int? Qty { get; set; }
    }
}
