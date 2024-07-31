using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderLineItemsTax
    {
        public int RowId { get; set; }
        public int TaxId { get; set; }
        public decimal TaxPercent { get; set; }
    }
}
