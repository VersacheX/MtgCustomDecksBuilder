using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingFedexActivity
    {
        public int ShipmentNum { get; set; }
        public short IndexNum { get; set; }
        public short StatusCodeId { get; set; }
        public string? City { get; set; }
        public string? StateProvinceCode { get; set; }
        public string? CountryCode { get; set; }
        public string? PostalCode { get; set; }
        public string? StatusTypeCode { get; set; }
        public string? StatusTypeDesc { get; set; }
        public DateTime? DateAndTime { get; set; }

        public virtual FedexStatusCode StatusCode { get; set; } = null!;
    }
}
