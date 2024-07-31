using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetSettlementOrder
    {
        public JetSettlementOrder()
        {
            JetSettlementOrderItems = new HashSet<JetSettlementOrderItem>();
        }

        public int Id { get; set; }
        public int JetSettlementId { get; set; }
        public string? MerchantOrderId { get; set; }
        public decimal? MerchantPrice { get; set; }
        public decimal? VariableCommission { get; set; }
        public decimal? BaseCommission { get; set; }
        public decimal? ShippingRevenue { get; set; }
        public decimal? Tax { get; set; }
        public decimal? ShippingTax { get; set; }
        public decimal? TotalOrderBalance { get; set; }

        public virtual JetSettlement JetSettlement { get; set; } = null!;
        public virtual ICollection<JetSettlementOrderItem> JetSettlementOrderItems { get; set; }
    }
}
