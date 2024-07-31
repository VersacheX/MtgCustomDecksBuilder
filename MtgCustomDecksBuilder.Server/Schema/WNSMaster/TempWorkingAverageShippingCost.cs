using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TempWorkingAverageShippingCost
    {
        public decimal? FromOunces { get; set; }
        public decimal? ToOunces { get; set; }
        public decimal? AvgStandardShippingCost { get; set; }
        public decimal? AvgEconomyShippingCost { get; set; }
    }
}
