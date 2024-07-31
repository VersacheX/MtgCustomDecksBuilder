using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingClaimsStatus
    {
        public OrdersProviderShippingClaimsStatus()
        {
            OrdersProviderShippingClaims = new HashSet<OrdersProviderShippingClaim>();
        }

        public byte StatusId { get; set; }
        public string Status { get; set; } = null!;

        public virtual ICollection<OrdersProviderShippingClaim> OrdersProviderShippingClaims { get; set; }
    }
}
