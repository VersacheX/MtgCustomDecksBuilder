using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EBayPayoutTransaction
    {
        public EBayPayoutTransaction()
        {
            EBayPayoutTransactionLines = new HashSet<EBayPayoutTransactionLine>();
        }

        public int Id { get; set; }
        public int EBayPayoutId { get; set; }
        public string? TransactionId { get; set; }
        public string? TransactionDate { get; set; }
        public string? TransactionStatus { get; set; }
        public string? TransactionType { get; set; }
        public string? OrderId { get; set; }
        public decimal? Amount { get; set; }
        public string? PaymentsEntity { get; set; }
        public string? SalesRecordReference { get; set; }
        public string? FeeType { get; set; }
        public decimal? TotalFeeBasisAmount { get; set; }
        public decimal? TotalFeeAmount { get; set; }
        public string? Username { get; set; }
        public string? TransactionMemo { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual EBayPayout EBayPayout { get; set; } = null!;
        public virtual ICollection<EBayPayoutTransactionLine> EBayPayoutTransactionLines { get; set; }
    }
}
