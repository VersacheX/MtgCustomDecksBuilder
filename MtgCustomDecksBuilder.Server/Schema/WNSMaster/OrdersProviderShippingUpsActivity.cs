using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingUpsActivity
    {
        public int ActivityId { get; set; }
        public int ShipmentNum { get; set; }
        public short StatusCodeId { get; set; }
        public string? City { get; set; }
        public string? StateProvinceCode { get; set; }
        public string? CountryCode { get; set; }
        public string? PostalCode { get; set; }
        public string? ActivityLocationCode { get; set; }
        public string? ActivityLocationDesc { get; set; }
        public string? StatusTypeCode { get; set; }
        public string? StatusTypeDesc { get; set; }
        public DateTime? DateAndTime { get; set; }
        public DateTime? DateAndTimeImported { get; set; }

        public virtual OrdersProviderShipping ShipmentNumNavigation { get; set; } = null!;
        public virtual UpsStatusCode StatusCode { get; set; } = null!;
    }
}
