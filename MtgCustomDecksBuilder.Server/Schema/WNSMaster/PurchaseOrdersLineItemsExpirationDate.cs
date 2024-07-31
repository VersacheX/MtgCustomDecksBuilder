using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseOrdersLineItemsExpirationDate
    {
        public long Uniquefier { get; set; }
        public int Ponum { get; set; }
        public int ProdId { get; set; }
        public int Qty { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
