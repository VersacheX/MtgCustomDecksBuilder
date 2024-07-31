using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class FedexFimsStdRatesOverride
    {
        public short OverrideId { get; set; }
        public short PeriodId { get; set; }
        public short CountryId { get; set; }
        public decimal CostPerPound { get; set; }

        public virtual ShipToCountry Country { get; set; } = null!;
        public virtual FedexFimsStdRatesPeriod Period { get; set; } = null!;
    }
}
