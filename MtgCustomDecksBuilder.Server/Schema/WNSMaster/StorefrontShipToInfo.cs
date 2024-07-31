using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontShipToInfo
    {
        public int ShipToId { get; set; }
        public short StorefrontId { get; set; }
        public string? ShipToLabel { get; set; }
        public string? ShipToFname { get; set; }
        public string? ShipToMname { get; set; }
        public string? ShipToLname { get; set; }
        public string? ShipToAddress { get; set; }
        public string? ShipToAddress2 { get; set; }
        public string? ShipToCity { get; set; }
        public string? ShipToState { get; set; }
        public string? ShipToZip { get; set; }
        public short? ShipToCountryId { get; set; }
        public string? ShipToPhone { get; set; }
        public string? ShipToEmail { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
