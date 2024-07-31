using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EcmsShipment
    {
        public int Id { get; set; }
        public int ShipmentNum { get; set; }
        public int? ManifestId { get; set; }
    }
}
