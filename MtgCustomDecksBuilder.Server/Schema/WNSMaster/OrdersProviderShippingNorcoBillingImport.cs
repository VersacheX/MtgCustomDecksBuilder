using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingNorcoBillingImport
    {
        public OrdersProviderShippingNorcoBillingImport()
        {
            OrdersProviderShippingNorcoBillings = new HashSet<OrdersProviderShippingNorcoBilling>();
        }

        public int ImportId { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime DateOfImport { get; set; }
        public string? Results { get; set; }

        public virtual ICollection<OrdersProviderShippingNorcoBilling> OrdersProviderShippingNorcoBillings { get; set; }
    }
}
