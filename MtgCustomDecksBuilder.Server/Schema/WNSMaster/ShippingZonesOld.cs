using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ShippingZonesOld
    {
        public byte ZoneId { get; set; }
        public short WrhsId { get; set; }
        public string BegZip { get; set; } = null!;
        public string EndZip { get; set; } = null!;
    }
}
