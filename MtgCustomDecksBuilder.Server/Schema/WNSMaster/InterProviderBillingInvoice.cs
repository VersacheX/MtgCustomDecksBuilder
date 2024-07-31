using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class InterProviderBillingInvoice
    {
        public InterProviderBillingInvoice()
        {
            InterProviderBillingPaymentToInvoiceRelationships = new HashSet<InterProviderBillingPaymentToInvoiceRelationship>();
        }

        public int InvoiceId { get; set; }
        public bool IsClosed { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public short FromProviderId { get; set; }
        public short ToProviderId { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string? InvoiceNotes { get; set; }

        public virtual Provider FromProvider { get; set; } = null!;
        public virtual Provider ToProvider { get; set; } = null!;
        public virtual ICollection<InterProviderBillingPaymentToInvoiceRelationship> InterProviderBillingPaymentToInvoiceRelationships { get; set; }
    }
}
