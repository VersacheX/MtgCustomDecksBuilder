using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingFedexBillingCharge
    {
        public long ChargeId { get; set; }
        public long DetailId { get; set; }
        public string? ChargeDesc { get; set; }
        public decimal? ChargeAmount { get; set; }

        public virtual OrdersProviderShippingFedexBilling Detail { get; set; } = null!;
    }
}
