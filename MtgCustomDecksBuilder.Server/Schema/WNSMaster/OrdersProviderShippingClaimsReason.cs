using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingClaimsReason
    {
        public OrdersProviderShippingClaimsReason()
        {
            OrdersProviderShippingClaims = new HashSet<OrdersProviderShippingClaim>();
        }

        public byte ReasonId { get; set; }
        public string? Reason { get; set; }

        public virtual ICollection<OrdersProviderShippingClaim> OrdersProviderShippingClaims { get; set; }
    }
}
