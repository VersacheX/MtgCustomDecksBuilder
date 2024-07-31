using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingGsoBillingAdjustment
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }
        public DateTime? DateAndTime { get; set; }
        public string? Reference { get; set; }
        public string? Description { get; set; }
        public string? Comments { get; set; }
        public decimal? Amount { get; set; }

        public virtual OrdersProviderShippingGsoBillingImport Import { get; set; } = null!;
    }
}
