using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EBayPayout
    {
        public EBayPayout()
        {
            EBayPayoutTransactions = new HashSet<EBayPayoutTransaction>();
        }

        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string? PayoutId { get; set; }
        public string? PayoutStatus { get; set; }
        public string? PayoutStatusDescription { get; set; }
        public int? TransactionCount { get; set; }
        public decimal? Amount { get; set; }
        public string? PayoutDate { get; set; }
        public string? LastAttemptedPayoutDate { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<EBayPayoutTransaction> EBayPayoutTransactions { get; set; }
    }
}
