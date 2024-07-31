using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsGroundRate
    {
        public short PeriodId { get; set; }
        public byte Weight { get; set; }
        public byte Zone { get; set; }
        public decimal Rate { get; set; }

        public virtual UpsGroundRatesPeriod Period { get; set; } = null!;
    }
}
