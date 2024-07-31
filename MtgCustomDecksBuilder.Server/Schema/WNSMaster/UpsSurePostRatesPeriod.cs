using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsSurePostRatesPeriod
    {
        public UpsSurePostRatesPeriod()
        {
            UpsSurePostRates = new HashSet<UpsSurePostRate>();
        }

        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<UpsSurePostRate> UpsSurePostRates { get; set; }
    }
}
