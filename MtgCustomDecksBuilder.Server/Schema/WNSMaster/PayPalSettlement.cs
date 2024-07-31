using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PayPalSettlement
    {
        public PayPalSettlement()
        {
            PayPalSettlementTransactions = new HashSet<PayPalSettlementTransaction>();
        }

        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string ReferenceId { get; set; } = null!;
        public DateTime Date { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<PayPalSettlementTransaction> PayPalSettlementTransactions { get; set; }
    }
}
