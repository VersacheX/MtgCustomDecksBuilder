using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderDropshippingTransaction
    {
        public int TransNum { get; set; }
        public DateTime TransTime { get; set; }
        public short StorefrontId { get; set; }
        public int? ProviderOrderId { get; set; }
        public byte TransClassId { get; set; }
        public string TransDesc { get; set; } = null!;
        public int? InvoiceIdassignedTo { get; set; }
        public int? ProdId { get; set; }
        public int? Qty { get; set; }
        public decimal? UnitCost { get; set; }
        public string? Reference1 { get; set; }

        public virtual OrdersProviderDropshippingInvoice? InvoiceIdassignedToNavigation { get; set; }
        public virtual StorefrontInfo Storefront { get; set; } = null!;
        public virtual OrdersProviderDropshippingTransactionsClass TransClass { get; set; } = null!;
    }
}
