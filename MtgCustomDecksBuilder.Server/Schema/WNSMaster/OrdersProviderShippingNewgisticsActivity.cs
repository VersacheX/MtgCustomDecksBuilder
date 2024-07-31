using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingNewgisticsActivity
    {
        public int ActivityId { get; set; }
        public int ShipmentNum { get; set; }
        public string TrackDetail { get; set; } = null!;
        public string? City { get; set; }
        public string? StateProvinceCode { get; set; }
        public string? PostalCode { get; set; }
        public DateTime? DateAndTime { get; set; }
        public DateTime DateAndTimeImported { get; set; }

        public virtual OrdersProviderShipping ShipmentNumNavigation { get; set; } = null!;
    }
}
