using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingMiscCarriersBilling
    {
        public int DetailId { get; set; }
        public int ShipmentNum { get; set; }
        public string? Bolnumber { get; set; }
        public decimal? Amount { get; set; }
        public string? Description { get; set; }
        public decimal? ProcessingFee { get; set; }
        public DateTime DateImported { get; set; }

        public virtual OrdersProviderShipping ShipmentNumNavigation { get; set; } = null!;
    }
}
