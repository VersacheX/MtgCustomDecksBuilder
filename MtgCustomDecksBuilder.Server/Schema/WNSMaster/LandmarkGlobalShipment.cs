using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class LandmarkGlobalShipment
    {
        public int ShipmentNum { get; set; }
        public byte SettingId { get; set; }
        public int? ManifestId { get; set; }
    }
}
