using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderLineItemsTaxShipping
    {
        public int ProviderOrderId { get; set; }
        public int TaxId { get; set; }
        public decimal TaxPercent { get; set; }
    }
}
