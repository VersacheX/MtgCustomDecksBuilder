using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class FedexFimsStdRatesPeriod
    {
        public FedexFimsStdRatesPeriod()
        {
            FedexFimsStdRatesOverrides = new HashSet<FedexFimsStdRatesOverride>();
        }

        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DefaultCostPerPound { get; set; }

        public virtual ICollection<FedexFimsStdRatesOverride> FedexFimsStdRatesOverrides { get; set; }
    }
}
