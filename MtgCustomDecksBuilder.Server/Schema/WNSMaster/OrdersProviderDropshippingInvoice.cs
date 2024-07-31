using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderDropshippingInvoice
    {
        public OrdersProviderDropshippingInvoice()
        {
            OrdersProviderDropshippingPaymentToInvoiceRelationships = new HashSet<OrdersProviderDropshippingPaymentToInvoiceRelationship>();
        }

        public int InvoiceId { get; set; }
        public bool IsClosed { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public short StorefrontId { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string? InvoiceNotes { get; set; }
        public DateTime? DateDue { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
        public virtual ICollection<OrdersProviderDropshippingPaymentToInvoiceRelationship> OrdersProviderDropshippingPaymentToInvoiceRelationships { get; set; }
    }
}
