using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetSettlement
    {
        public JetSettlement()
        {
            JetSettlementOrders = new HashSet<JetSettlementOrder>();
            JetSettlementReturns = new HashSet<JetSettlementReturn>();
        }

        public int Id { get; set; }
        public string? ReportId { get; set; }
        public string? State { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? Currency { get; set; }
        public decimal? UnavailableBalance { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public decimal? OrderBalance { get; set; }
        public decimal? ReturnBalance { get; set; }
        public decimal? JetAdjustment { get; set; }
        public decimal? Value { get; set; }
        public decimal? OrderMerchantPrice { get; set; }
        public decimal? OrderVariableCommission { get; set; }
        public decimal? OrderBaseCommission { get; set; }
        public decimal? OrderTax { get; set; }
        public decimal? OrderShippingRevenue { get; set; }
        public decimal? OrderShippingTax { get; set; }
        public decimal? OrderShippingCharge { get; set; }
        public decimal? OrderFulfillmentFee { get; set; }
        public decimal? ReturnMerchantPrice { get; set; }
        public decimal? ReturnVariableCommission { get; set; }
        public decimal? ReturnBaseCommission { get; set; }
        public decimal? ReturnTax { get; set; }
        public decimal? ReturnShippingRevenue { get; set; }
        public decimal? ReturnShippingTax { get; set; }
        public decimal? ReturnMerchantReturnCharge { get; set; }
        public decimal? ReturnProcessingFee { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? ReportId1 { get; set; }
        public DateTime? CompletedOn { get; set; }

        public virtual ICollection<JetSettlementOrder> JetSettlementOrders { get; set; }
        public virtual ICollection<JetSettlementReturn> JetSettlementReturns { get; set; }
    }
}
