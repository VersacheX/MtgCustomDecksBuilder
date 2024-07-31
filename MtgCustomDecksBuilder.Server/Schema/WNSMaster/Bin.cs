using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Bin
    {
        public Bin()
        {
            BinProdRelationships = new HashSet<BinProdRelationship>();
        }

        public string BinId { get; set; } = null!;
        public short WrhsId { get; set; }

        public virtual ICollection<BinProdRelationship> BinProdRelationships { get; set; }
    }
}
