using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WalmartOrderLine
    {
        public int Id { get; set; }
        public int WalmartOrderId { get; set; }
        public int LineNumber { get; set; }
        public string? ProductName { get; set; }
        public int ProdId { get; set; }
        public string? Sku { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? Tax { get; set; }
        public DateTime? ShippedOn { get; set; }
        public DateTime? CancelledOn { get; set; }

        public virtual WalmartOrder WalmartOrder { get; set; } = null!;
    }
}
