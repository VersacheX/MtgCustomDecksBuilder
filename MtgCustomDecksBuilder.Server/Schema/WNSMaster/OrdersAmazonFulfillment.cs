using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersAmazonFulfillment
    {
        public int ProviderOrderId { get; set; }
        public int Fulfilled { get; set; }
        public string? Message { get; set; }
    }
}
