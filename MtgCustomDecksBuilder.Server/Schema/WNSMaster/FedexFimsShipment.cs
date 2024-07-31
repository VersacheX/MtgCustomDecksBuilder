using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class FedexFimsShipment
    {
        public int ShipmentNum { get; set; }
        public int SettingId { get; set; }
        public decimal Cost { get; set; }
        public int? ManifestId { get; set; }
    }
}
