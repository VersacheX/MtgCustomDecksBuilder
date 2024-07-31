using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class FedexStatusCode
    {
        public FedexStatusCode()
        {
            OrdersProviderShippingFedexActivities = new HashSet<OrdersProviderShippingFedexActivity>();
        }

        public short StatusCodeId { get; set; }
        public string StatusCode { get; set; } = null!;
        public byte StatusType { get; set; }
        public string? InternalDesc { get; set; }
        public bool? HideOnReport { get; set; }

        public virtual ICollection<OrdersProviderShippingFedexActivity> OrdersProviderShippingFedexActivities { get; set; }
    }
}
