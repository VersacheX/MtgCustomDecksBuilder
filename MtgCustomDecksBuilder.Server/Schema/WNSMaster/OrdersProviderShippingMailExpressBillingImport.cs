using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingMailExpressBillingImport
    {
        public OrdersProviderShippingMailExpressBillingImport()
        {
            OrdersProviderShippingMailExpressBillings = new HashSet<OrdersProviderShippingMailExpressBilling>();
        }

        public int ImportId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<OrdersProviderShippingMailExpressBilling> OrdersProviderShippingMailExpressBillings { get; set; }
    }
}
