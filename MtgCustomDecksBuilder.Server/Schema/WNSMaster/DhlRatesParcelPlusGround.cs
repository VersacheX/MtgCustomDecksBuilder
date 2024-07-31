using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DhlRatesParcelPlusGround
    {
        public short PeriodId { get; set; }
        public decimal Weight { get; set; }
        public byte Zone { get; set; }
        public decimal Rate { get; set; }

        public virtual DhlRatesPeriod Period { get; set; } = null!;
    }
}
