using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SagawaRatesPeriod
    {
        public SagawaRatesPeriod()
        {
            SagawaRates = new HashSet<SagawaRate>();
        }

        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<SagawaRate> SagawaRates { get; set; }
    }
}
