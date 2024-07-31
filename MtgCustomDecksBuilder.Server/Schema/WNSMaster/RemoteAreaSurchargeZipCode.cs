using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class RemoteAreaSurchargeZipCode
    {
        public int RecordId { get; set; }
        public byte CarrierId { get; set; }
        public string CountryCode { get; set; } = null!;
        public string? PostalCodeLow { get; set; }
        public string? PostalCodeHigh { get; set; }
        public string? City { get; set; }
        public bool? Extended { get; set; }

        public virtual RemoteAreaSurchargeCarrier Carrier { get; set; } = null!;
    }
}
