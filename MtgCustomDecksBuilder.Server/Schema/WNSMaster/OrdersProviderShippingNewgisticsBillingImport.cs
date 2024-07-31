using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingNewgisticsBillingImport
    {
        public OrdersProviderShippingNewgisticsBillingImport()
        {
            OrdersProviderShippingNewgisticsBillings = new HashSet<OrdersProviderShippingNewgisticsBilling>();
        }

        public int ImportId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<OrdersProviderShippingNewgisticsBilling> OrdersProviderShippingNewgisticsBillings { get; set; }
    }
}
