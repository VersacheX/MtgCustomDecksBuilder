using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AffiliatesTransactionsStatus
    {
        public byte StatusId { get; set; }
        public string Description { get; set; } = null!;
    }
}
