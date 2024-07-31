using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EBayOrderLine
    {
        public int Id { get; set; }
        public int EBayOrderId { get; set; }
        public string OrderLineItemId { get; set; } = null!;
        public string? TransactionId { get; set; }
        public string? BuyerEmail { get; set; }
        public int ProdId { get; set; }
        public string? Sku { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? Tax { get; set; }
        public DateTime? ShippedOn { get; set; }
        public DateTime? CancelledOn { get; set; }

        public virtual EBayOrder EBayOrder { get; set; } = null!;
    }
}
