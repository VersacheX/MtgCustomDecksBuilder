using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingBoxSuggestionsSuggestGroup
    {
        public int LineNum { get; set; }
        public int SuggestId { get; set; }
        public int ProdId { get; set; }
        public byte Qty { get; set; }
    }
}
