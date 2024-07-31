using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderWholesalePaymentsPaymentToOrderRelationship
    {
        public int RelationshipId { get; set; }
        public int ProviderOrderId { get; set; }
        public int PaymentId { get; set; }
        public decimal AmountApplied { get; set; }
        public DateTime DateApplied { get; set; }

        public virtual OrdersProviderWholesalePayment Payment { get; set; } = null!;
    }
}
