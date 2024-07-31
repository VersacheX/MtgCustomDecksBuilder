using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WorkingTableSfmanageProductsPage
    {
        public string UniqueQueryId { get; set; } = null!;
        public int ProdId { get; set; }
    }
}
