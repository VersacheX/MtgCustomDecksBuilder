using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UspsTransitTime
    {
        public short FromWrhsId { get; set; }
        public byte CarrierAndClassId { get; set; }
        public string ToZip { get; set; } = null!;
        public short DaysInTransit { get; set; }
    }
}
