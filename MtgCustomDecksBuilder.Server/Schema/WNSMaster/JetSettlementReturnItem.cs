using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetSettlementReturnItem
    {
        public int Id { get; set; }
        public int JetSettlementReturnId { get; set; }
        public string? OrderItemId { get; set; }
        public string? ReturnId { get; set; }
        public string? ReturnLocation { get; set; }
        public decimal? MerchantPrice { get; set; }
        public decimal? VariableCommission { get; set; }
        public decimal? BaseCommission { get; set; }
        public decimal? ShippingRevenue { get; set; }
        public decimal? Tax { get; set; }
        public decimal? ShippingTax { get; set; }
        public decimal? MerchantReturnCharge { get; set; }
        public decimal? TotalReturnItemBalance { get; set; }

        public virtual JetSettlementReturn JetSettlementReturn { get; set; } = null!;
    }
}
