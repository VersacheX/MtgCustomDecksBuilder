using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AlturaShipInfo
    {
        public byte ShipMethodId { get; set; }
        public short CountryId { get; set; }
        public byte ZoneId { get; set; }
        public decimal PerOrderFee { get; set; }
        public decimal PerItemFee { get; set; }
        public decimal PerOunceFee { get; set; }
        public bool AllowedByProvider { get; set; }
        public string? FlatOrZipDependent { get; set; }
        public bool? IsDefault { get; set; }
    }
}
