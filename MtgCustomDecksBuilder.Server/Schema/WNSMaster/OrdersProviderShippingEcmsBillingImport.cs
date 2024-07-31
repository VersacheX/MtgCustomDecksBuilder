using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingEcmsBillingImport
    {
        public OrdersProviderShippingEcmsBillingImport()
        {
            OrdersProviderShippingEcmsBillings = new HashSet<OrdersProviderShippingEcmsBilling>();
        }

        public int ImportId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<OrdersProviderShippingEcmsBilling> OrdersProviderShippingEcmsBillings { get; set; }
    }
}
