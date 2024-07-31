using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderDropshippingIgnoreBilling
    {
        public int ProviderOrderId { get; set; }
        public string? Reason { get; set; }
    }
}
