using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsStatusCode
    {
        public UpsStatusCode()
        {
            OrdersProviderShippingUpsActivities = new HashSet<OrdersProviderShippingUpsActivity>();
        }

        public short StatusCodeId { get; set; }
        public string? StatusCode { get; set; }
        public byte? StatusType { get; set; }
        public string? InternalDesc { get; set; }
        public bool? IsNotUpsErrorObsolete { get; set; }
        public bool? HideOnReport { get; set; }

        public virtual ICollection<OrdersProviderShippingUpsActivity> OrdersProviderShippingUpsActivities { get; set; }
    }
}
