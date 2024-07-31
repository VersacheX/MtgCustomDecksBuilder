using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderLineItemsAmazon
    {
        public int ProviderOrderId { get; set; }
        public string Sku { get; set; } = null!;
        public int ProdId { get; set; }
        public short Qty { get; set; }
    }
}
