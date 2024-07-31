using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetSettlementOrderItem
    {
        public int Id { get; set; }
        public int JetSettlementOrderId { get; set; }
        public string? OrderItemId { get; set; }
        public string? FulfillmentMethod { get; set; }
        public decimal? MerchantPrice { get; set; }
        public decimal? VariableCommission { get; set; }
        public decimal? BaseCommission { get; set; }
        public decimal? ShippingRevenue { get; set; }
        public decimal? Tax { get; set; }
        public decimal? ShippingTax { get; set; }
        public decimal? TotalOrderItemBalance { get; set; }

        public virtual JetSettlementOrder JetSettlementOrder { get; set; } = null!;
    }
}
