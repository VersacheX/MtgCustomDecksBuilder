using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PayPalSettlementTransaction
    {
        public int Id { get; set; }
        public int PayPalSettlementId { get; set; }
        public int ProviderOrderId { get; set; }
        public string? TransactionId { get; set; }
        public string? InvoiceId { get; set; }
        public string? PayPalReferenceId { get; set; }
        public string? PayPalReferenceIdtype { get; set; }
        public string? TransactionEventCode { get; set; }
        public DateTime? TransactionInitiationDate { get; set; }
        public DateTime? TransactionCompletionDate { get; set; }
        public string? TransactionDebitOrCredit { get; set; }
        public decimal? GrossTransactionAmount { get; set; }
        public string? GrossTransactionCurrency { get; set; }
        public string? FeeDebitOrCredit { get; set; }
        public decimal? FeeAmount { get; set; }
        public string? FeeCurrency { get; set; }
        public string? CustomField { get; set; }
        public string? ConsumerId { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual PayPalSettlement PayPalSettlement { get; set; } = null!;
    }
}
