using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsSamplesInventory
    {
        public int SampleId { get; set; }
        public short WrhsId { get; set; }
        public int Qty { get; set; }

        public virtual ProdsSample Sample { get; set; } = null!;
        public virtual Warehouse Wrhs { get; set; } = null!;
    }
}
