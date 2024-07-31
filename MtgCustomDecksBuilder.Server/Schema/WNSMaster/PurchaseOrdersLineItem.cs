using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseOrdersLineItem
    {
        public PurchaseOrdersLineItem()
        {
            OrdersProviderLineItemsInventoryAllocations = new HashSet<OrdersProviderLineItemsInventoryAllocation>();
        }

        public long Uniquefier { get; set; }
        public long? MirrorUniquefier { get; set; }
        public short WrhsId { get; set; }
        public int Ponum { get; set; }
        public int ProdId { get; set; }
        public int QtyOrdered { get; set; }
        public int QtyInInventory { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? RebatePercent { get; set; }
        public string? NotesForDebugTracking { get; set; }

        public virtual PurchaseOrder PonumNavigation { get; set; } = null!;
        public virtual ICollection<OrdersProviderLineItemsInventoryAllocation> OrdersProviderLineItemsInventoryAllocations { get; set; }
    }
}
