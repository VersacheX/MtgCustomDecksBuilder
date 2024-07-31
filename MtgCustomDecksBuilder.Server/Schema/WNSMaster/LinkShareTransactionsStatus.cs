using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class LinkShareTransactionsStatus
    {
        public LinkShareTransactionsStatus()
        {
            LinkShareTransactions = new HashSet<LinkShareTransaction>();
        }

        public byte StatusId { get; set; }
        public string StatusDesc { get; set; } = null!;

        public virtual ICollection<LinkShareTransaction> LinkShareTransactions { get; set; }
    }
}
