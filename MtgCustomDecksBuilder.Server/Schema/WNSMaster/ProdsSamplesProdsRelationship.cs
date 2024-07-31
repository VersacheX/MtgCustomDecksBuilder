using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsSamplesProdsRelationship
    {
        public int SampleId { get; set; }
        public int ProdId { get; set; }
        public short StorefrontId { get; set; }

        public virtual ProdsProduct Prod { get; set; } = null!;
        public virtual ProdsSample Sample { get; set; } = null!;
    }
}
