using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingDhlglobalMailBillingImport
    {
        public OrdersProviderShippingDhlglobalMailBillingImport()
        {
            OrdersProviderShippingDhlglobalMailBillings = new HashSet<OrdersProviderShippingDhlglobalMailBilling>();
        }

        public int ImportId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<OrdersProviderShippingDhlglobalMailBilling> OrdersProviderShippingDhlglobalMailBillings { get; set; }
    }
}
