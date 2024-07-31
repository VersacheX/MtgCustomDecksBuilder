using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ShippingExtAreaSurchargeZipsIntl2010obsoletedatum
    {
        public int RecordId { get; set; }
        public string CountryCode { get; set; } = null!;
        public string? PostalCodeLow { get; set; }
        public string? PostalCodeHigh { get; set; }
        public string? City { get; set; }
    }
}
