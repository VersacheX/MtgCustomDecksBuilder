using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DhlGlobalMailRatesParcelPriorityDdu
    {
        public short PeriodId { get; set; }
        public short CountryId { get; set; }
        public short WeightInOz { get; set; }
        public decimal Rate { get; set; }

        public virtual ShipToCountry Country { get; set; } = null!;
        public virtual DhlGlobalMailRatesPeriod Period { get; set; } = null!;
    }
}
