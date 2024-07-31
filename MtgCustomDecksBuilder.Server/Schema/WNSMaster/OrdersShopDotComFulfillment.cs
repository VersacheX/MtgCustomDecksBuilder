using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersShopDotComFulfillment
    {
        public int ProviderOrderId { get; set; }
        public int ProdId { get; set; }
        public short Quantity { get; set; }
        public string InvoiceNum { get; set; } = null!;
        public string PurchaseId { get; set; } = null!;
        public bool Fulfilled { get; set; }
        public DateTime LastModified { get; set; }
    }
}
