using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DhlGlobalMailRatesParcelPriorityV2
    {
        public short PeriodId { get; set; }
        public short WeightInOz { get; set; }
        public int Zone { get; set; }
        public decimal Rate { get; set; }

        public virtual DhlGlobalMailRatesPeriod Period { get; set; } = null!;
    }
}
