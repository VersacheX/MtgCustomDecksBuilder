using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingGsoBillingImport
    {
        public OrdersProviderShippingGsoBillingImport()
        {
            OrdersProviderShippingGsoBillingAdjustments = new HashSet<OrdersProviderShippingGsoBillingAdjustment>();
            OrdersProviderShippingGsoBillings = new HashSet<OrdersProviderShippingGsoBilling>();
        }

        public int ImportId { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<OrdersProviderShippingGsoBillingAdjustment> OrdersProviderShippingGsoBillingAdjustments { get; set; }
        public virtual ICollection<OrdersProviderShippingGsoBilling> OrdersProviderShippingGsoBillings { get; set; }
    }
}
