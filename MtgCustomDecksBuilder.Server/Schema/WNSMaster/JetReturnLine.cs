using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetReturnLine
    {
        public int Id { get; set; }
        public int JetReturnId { get; set; }
        public string? OrderItemId { get; set; }
        public string? MerchantSku { get; set; }
        public string? MerchantSkutitle { get; set; }
        public int? ReturnQuantity { get; set; }
        public string? Reason { get; set; }
        public decimal? Principal { get; set; }
        public decimal? Tax { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? ShippingTax { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? QuantityReturned { get; set; }
        public int? RefundQuantity { get; set; }
        public decimal? RefundPrincipal { get; set; }
        public decimal? RefundTax { get; set; }
        public decimal? RefundShippingCost { get; set; }
        public decimal? RefundShippingTax { get; set; }
        public string? RefundFeedback { get; set; }
        public string? Notes { get; set; }
        public DateTime? RefundedOn { get; set; }

        public virtual JetReturn JetReturn { get; set; } = null!;
    }
}
