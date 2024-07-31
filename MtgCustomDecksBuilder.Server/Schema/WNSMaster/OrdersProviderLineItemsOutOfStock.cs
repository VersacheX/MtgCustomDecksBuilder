using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderLineItemsOutOfStock
    {
        public int ProviderOrderId { get; set; }
        public int ProdId { get; set; }
        public short WrhsId { get; set; }
        public int QtyMissing { get; set; }
        public short AdminId { get; set; }
        public DateTime DateMissing { get; set; }

        public virtual ProdsProduct Prod { get; set; } = null!;
    }
}
