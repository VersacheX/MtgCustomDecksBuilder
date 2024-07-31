using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderWholesalePayment
    {
        public OrdersProviderWholesalePayment()
        {
            OrdersProviderWholesalePaymentsCreditMemoLineItems = new HashSet<OrdersProviderWholesalePaymentsCreditMemoLineItem>();
            OrdersProviderWholesalePaymentsPaymentToOrderRelationships = new HashSet<OrdersProviderWholesalePaymentsPaymentToOrderRelationship>();
        }

        public int PaymentId { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public short StorefrontId { get; set; }
        public string TransType { get; set; } = null!;
        public int? AppliedToPaymentId { get; set; }
        public string? AttemptedTransType { get; set; }
        public decimal TransAmount { get; set; }
        public string? CcholderName { get; set; }
        public byte[]? CcnumberEnc { get; set; }
        public string? CcexpMonth { get; set; }
        public string? CcexpYear { get; set; }
        public int? ProviderOrderIdLegacy { get; set; }
        public int? TransNumLegacy { get; set; }
        public int? AppliedToTransLegacy { get; set; }
        public string? AuthNetResponseCode { get; set; }
        public string? AuthNetResponseReasonCode { get; set; }
        public string? AuthNetResponseReasonText { get; set; }
        public string? AuthNetAuthorizationCode { get; set; }
        public string? AuthNetAvscode { get; set; }
        public string? AuthNetTransactionId { get; set; }
        public int? CbtransactionId { get; set; }
        public short? CbstatusId { get; set; }
        public string? CbresponseCode { get; set; }
        public string? CbresponseText { get; set; }
        public string? CbapprovalCode { get; set; }
        public string? CbavsresultCode { get; set; }
        public string? CberrorMsg { get; set; }
        public bool? IsPayTech { get; set; }
        public string? PayTechResponseText { get; set; }
        public string? PayTechAuthorizationCode { get; set; }
        public byte? PayTechApprovalStatus { get; set; }
        public string? PayTechRespCode { get; set; }
        public string? PayTechRespCodeMsg { get; set; }
        public string? PayTechAvsrespCode { get; set; }
        public string? PayTechCvvrespCode { get; set; }
        public string? PayTechTransRefId { get; set; }
        public string? PayTechTransRefNum { get; set; }
        public string? PayTechRespDateTime { get; set; }
        public string? CheckNum { get; set; }
        public string? CheckAccountNum { get; set; }
        public string? CheckRoutingNum { get; set; }
        public byte? CheckAccountType { get; set; }
        public string? ChargebackCaseNum { get; set; }
        public string? CreditMemoNotesToPrint { get; set; }
        public string? TransactionNotes { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }

        public virtual ICollection<OrdersProviderWholesalePaymentsCreditMemoLineItem> OrdersProviderWholesalePaymentsCreditMemoLineItems { get; set; }
        public virtual ICollection<OrdersProviderWholesalePaymentsPaymentToOrderRelationship> OrdersProviderWholesalePaymentsPaymentToOrderRelationships { get; set; }
    }
}
