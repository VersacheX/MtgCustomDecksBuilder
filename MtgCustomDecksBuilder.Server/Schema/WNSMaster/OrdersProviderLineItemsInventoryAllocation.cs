using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderLineItemsInventoryAllocation
    {
        public int RowId { get; set; }
        public int ProviderOrderId { get; set; }
        public long? PoLiUniquefier { get; set; }
        public int Qty { get; set; }
        public DateTime DateAndTime { get; set; }

        public virtual PurchaseOrdersLineItem? PoLiUniquefierNavigation { get; set; }
    }
}
