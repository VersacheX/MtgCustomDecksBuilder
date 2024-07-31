using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetOrderLine
    {
        public JetOrderLine()
        {
            JetOrderLineFeeAdjustments = new HashSet<JetOrderLineFeeAdjustment>();
        }

        public int Id { get; set; }
        public int JetOrderId { get; set; }
        public string OrderItemId { get; set; } = null!;
        public string MerchantSku { get; set; } = null!;
        public int ProdId { get; set; }
        public int RequestOrderQuantity { get; set; }
        public int RequestOrderCancelQty { get; set; }
        public string? ItemTaxCode { get; set; }
        public decimal? ItemTax { get; set; }
        public decimal? ItemShippingCost { get; set; }
        public decimal? ItemShippingTax { get; set; }
        public decimal BasePrice { get; set; }
        public string ProductTitle { get; set; } = null!;
        public string Url { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime? ShippedOn { get; set; }
        public DateTime? CancelledOn { get; set; }

        public virtual JetOrder JetOrder { get; set; } = null!;
        public virtual ICollection<JetOrderLineFeeAdjustment> JetOrderLineFeeAdjustments { get; set; }
    }
}
