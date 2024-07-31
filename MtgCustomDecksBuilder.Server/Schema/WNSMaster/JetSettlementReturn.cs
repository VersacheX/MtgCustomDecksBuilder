using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetSettlementReturn
    {
        public JetSettlementReturn()
        {
            JetSettlementReturnItems = new HashSet<JetSettlementReturnItem>();
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
        public decimal? MerchantReturnCharge { get; set; }
        public decimal? TotalReturnBalance { get; set; }

        public virtual JetSettlement JetSettlement { get; set; } = null!;
        public virtual ICollection<JetSettlementReturnItem> JetSettlementReturnItems { get; set; }
    }
}
