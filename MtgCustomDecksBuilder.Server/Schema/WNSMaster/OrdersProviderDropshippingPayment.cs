using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderDropshippingPayment
    {
        public OrdersProviderDropshippingPayment()
        {
            OrdersProviderDropshippingPaymentToInvoiceRelationships = new HashSet<OrdersProviderDropshippingPaymentToInvoiceRelationship>();
        }

        public int PaymentId { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public short StorefrontId { get; set; }
        public decimal PaymentAmount { get; set; }
        public string? PaymentNotes { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
        public virtual ICollection<OrdersProviderDropshippingPaymentToInvoiceRelationship> OrdersProviderDropshippingPaymentToInvoiceRelationships { get; set; }
    }
}
