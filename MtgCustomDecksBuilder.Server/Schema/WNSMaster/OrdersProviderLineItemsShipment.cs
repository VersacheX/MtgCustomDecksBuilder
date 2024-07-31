using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderLineItemsShipment
    {
        public int Uniquefier { get; set; }
        public int LineItemRowId { get; set; }
        public int ShipmentNum { get; set; }

        public virtual OrdersProviderLineItem LineItemRow { get; set; } = null!;
        public virtual OrdersProviderShipping ShipmentNumNavigation { get; set; } = null!;
    }
}
