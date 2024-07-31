using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SagawaRate
    {
        public short PeriodId { get; set; }
        public decimal WeightInLbs { get; set; }
        public decimal Rate { get; set; }

        public virtual SagawaRatesPeriod Period { get; set; } = null!;
    }
}
