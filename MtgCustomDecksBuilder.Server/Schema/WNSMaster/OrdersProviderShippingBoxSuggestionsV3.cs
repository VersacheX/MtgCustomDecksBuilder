using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingBoxSuggestionsV3
    {
        public int SuggestId { get; set; }
        public short? AdminId { get; set; }
        public string BoxDescription { get; set; } = null!;
    }
}
