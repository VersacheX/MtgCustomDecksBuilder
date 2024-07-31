using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderConsumerPaymentsAndCredit
    {
        public int TransNum { get; set; }
        public DateTime TransTime { get; set; }
        public int ProviderOrderId { get; set; }
        public string TransType { get; set; } = null!;
        public int? AppliedToTrans { get; set; }
        public string? AttemptedTransType { get; set; }
        public decimal TransAmount { get; set; }
        public string? CcholderName { get; set; }
        public string? CcnumberObsolete { get; set; }
        public string? CcexpMonth { get; set; }
        public string? CcexpYear { get; set; }
        public string? Cccvv2 { get; set; }
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
        public string? MoneyOrderNotes { get; set; }
        public string? ChargebackCaseNum { get; set; }
        public string? TransactionNotes { get; set; }
        public byte[]? CcnumberEnc { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public string? PayTechCustRefNum { get; set; }
        public string? GatewayName { get; set; }
        public string? ResponseText { get; set; }
        public string? ResponseCode { get; set; }
        public string? ApprovalCode { get; set; }
        public string? AvsCode { get; set; }
        public string? CvvCode { get; set; }
        public string? TransRefNum { get; set; }
        public string? CustRefNum { get; set; }
        public string? MiscResponse1 { get; set; }
        public string? MiscResponse2 { get; set; }
        public string? MiscResponse3 { get; set; }
    }
}
