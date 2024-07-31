using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class BinProdRelationship
    {
        public string BinId { get; set; } = null!;
        public int ProdId { get; set; }
        public byte BinRank { get; set; }
        public int FenceQty { get; set; }

        public virtual Bin Bin { get; set; } = null!;
        public virtual ProdsProduct Prod { get; set; } = null!;
    }
}
