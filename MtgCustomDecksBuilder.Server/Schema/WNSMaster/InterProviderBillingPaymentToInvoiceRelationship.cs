using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class InterProviderBillingPaymentToInvoiceRelationship
    {
        public int RelationshipId { get; set; }
        public int InvoiceId { get; set; }
        public int PaymentId { get; set; }
        public decimal AmountApplied { get; set; }
        public DateTime DateApplied { get; set; }

        public virtual InterProviderBillingInvoice Invoice { get; set; } = null!;
    }
}
