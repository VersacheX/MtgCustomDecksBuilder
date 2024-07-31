using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseOrdersLineItemsRackingGroupsPallet
    {
        public int Id { get; set; }
        public int RackingGroupId { get; set; }
        public long PalletUniquefier { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual PurchaseOrdersLineItemsPallet PalletUniquefierNavigation { get; set; } = null!;
        public virtual PurchaseOrdersLineItemsRackingGroup RackingGroup { get; set; } = null!;
    }
}
