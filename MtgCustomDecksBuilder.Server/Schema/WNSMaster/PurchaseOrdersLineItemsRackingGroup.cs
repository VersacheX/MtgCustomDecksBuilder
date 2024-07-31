using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseOrdersLineItemsRackingGroup
    {
        public PurchaseOrdersLineItemsRackingGroup()
        {
            PurchaseOrdersLineItemsRackingGroupsPallets = new HashSet<PurchaseOrdersLineItemsRackingGroupsPallet>();
        }

        public int Id { get; set; }
        public short WrhsId { get; set; }
        public short? AdminId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ClosedOn { get; set; }

        public virtual ICollection<PurchaseOrdersLineItemsRackingGroupsPallet> PurchaseOrdersLineItemsRackingGroupsPallets { get; set; }
    }
}
