using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EBayPayoutTransactionLine
    {
        public int Id { get; set; }
        public int EBayPayoutTransactionId { get; set; }
        public string? LineItemId { get; set; }
        public decimal? FeeBasisAmount { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual EBayPayoutTransaction EBayPayoutTransaction { get; set; } = null!;
    }
}
