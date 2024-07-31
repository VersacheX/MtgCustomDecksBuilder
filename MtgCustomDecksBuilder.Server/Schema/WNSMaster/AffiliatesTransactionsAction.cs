using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AffiliatesTransactionsAction
    {
        public int ActionId { get; set; }
        public string Description { get; set; } = null!;
    }
}
