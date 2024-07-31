using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class FedexFimsPrmRatesPeriod
    {
        public FedexFimsPrmRatesPeriod()
        {
            FedexFimsPrmRatesOverrides = new HashSet<FedexFimsPrmRatesOverride>();
        }

        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DefaultCostPerPound { get; set; }

        public virtual ICollection<FedexFimsPrmRatesOverride> FedexFimsPrmRatesOverrides { get; set; }
    }
}
