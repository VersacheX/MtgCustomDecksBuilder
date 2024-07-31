using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TempAddressApiLog
    {
        public int RowId { get; set; }
        public short? ShipMethodId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? ResponseText { get; set; }
        public DateTime? DateAndTime { get; set; }
    }
}
