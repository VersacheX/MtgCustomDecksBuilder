using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class NgsTransitTime
    {
        public short FromWrhsId { get; set; }
        public string ToZip { get; set; } = null!;
        public decimal AvgDaysInTransit { get; set; }
    }
}
