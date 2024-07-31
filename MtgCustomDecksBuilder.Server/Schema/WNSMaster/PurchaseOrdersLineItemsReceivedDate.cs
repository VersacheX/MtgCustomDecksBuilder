using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseOrdersLineItemsReceivedDate
    {
        public long Uniquefier { get; set; }
        public int Ponum { get; set; }
        public int ProdId { get; set; }
        public int QtyReceived { get; set; }
        public DateTime DateReceived { get; set; }
        public short CheckedInBy { get; set; }
    }
}
