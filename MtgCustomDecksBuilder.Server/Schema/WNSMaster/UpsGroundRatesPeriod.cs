using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsGroundRatesPeriod
    {
        public UpsGroundRatesPeriod()
        {
            UpsGroundRates = new HashSet<UpsGroundRate>();
        }

        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<UpsGroundRate> UpsGroundRates { get; set; }
    }
}
