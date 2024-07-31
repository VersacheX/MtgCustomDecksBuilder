using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsBundlesMapping
    {
        public int MasterProdId { get; set; }
        public int ChildProdId { get; set; }
        public byte Qty { get; set; }
    }
}
