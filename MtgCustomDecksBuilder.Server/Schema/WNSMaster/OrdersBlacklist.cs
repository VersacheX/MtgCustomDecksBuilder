using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersBlacklist
    {
        public int BlacklistId { get; set; }
        public int ProviderOrderId { get; set; }
        public short StorefrontId { get; set; }
        public string BillToFname { get; set; } = null!;
        public string BillToLname { get; set; } = null!;
        public string BillToAddress { get; set; } = null!;
        public string? BillToAddress2 { get; set; }
        public string BillToCity { get; set; } = null!;
        public string BillToState { get; set; } = null!;
        public string BillToZip { get; set; } = null!;
        public string BillToCountry { get; set; } = null!;
        public string? BillToPhone { get; set; }
        public string? BillToEmail { get; set; }
        public string ShipToFname { get; set; } = null!;
        public string ShipToLname { get; set; } = null!;
        public string ShipToAddress { get; set; } = null!;
        public string? ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; } = null!;
        public string ShipToState { get; set; } = null!;
        public string ShipToZip { get; set; } = null!;
        public short ShipToCountryId { get; set; }
        public string? ShipToPhone { get; set; }
        public string? ShipToEmail { get; set; }
        public string? Comments { get; set; }
        public byte[]? CcnumberEnc { get; set; }
        public string? CartId { get; set; }
    }
}
