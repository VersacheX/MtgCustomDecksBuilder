using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingDhlexpressBillingImport
    {
        public OrdersProviderShippingDhlexpressBillingImport()
        {
            OrdersProviderShippingDhlexpressBillings = new HashSet<OrdersProviderShippingDhlexpressBilling>();
        }

        public int ImportId { get; set; }
        public string InvoiceNumber { get; set; } = null!;
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<OrdersProviderShippingDhlexpressBilling> OrdersProviderShippingDhlexpressBillings { get; set; }
    }
}
