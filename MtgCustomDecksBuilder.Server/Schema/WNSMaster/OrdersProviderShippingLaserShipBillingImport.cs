using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingLaserShipBillingImport
    {
        public OrdersProviderShippingLaserShipBillingImport()
        {
            OrdersProviderShippingLaserShipBillings = new HashSet<OrdersProviderShippingLaserShipBilling>();
        }

        public int ImportId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<OrdersProviderShippingLaserShipBilling> OrdersProviderShippingLaserShipBillings { get; set; }
    }
}
