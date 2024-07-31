using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingOnTracBillingImport
    {
        public OrdersProviderShippingOnTracBillingImport()
        {
            OrdersProviderShippingOnTracBillings = new HashSet<OrdersProviderShippingOnTracBilling>();
        }

        public int ImportId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<OrdersProviderShippingOnTracBilling> OrdersProviderShippingOnTracBillings { get; set; }
    }
}
