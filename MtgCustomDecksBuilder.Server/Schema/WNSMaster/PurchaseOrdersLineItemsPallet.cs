using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseOrdersLineItemsPallet
    {
        public PurchaseOrdersLineItemsPallet()
        {
            PurchaseOrdersLineItemsRackingGroupsPallets = new HashSet<PurchaseOrdersLineItemsRackingGroupsPallet>();
        }

        public long Uniquefier { get; set; }
        public int Ponum { get; set; }
        public int ProdId { get; set; }
        public int Qty { get; set; }
        public short Pallet { get; set; }

        public virtual ICollection<PurchaseOrdersLineItemsRackingGroupsPallet> PurchaseOrdersLineItemsRackingGroupsPallets { get; set; }
    }
}
