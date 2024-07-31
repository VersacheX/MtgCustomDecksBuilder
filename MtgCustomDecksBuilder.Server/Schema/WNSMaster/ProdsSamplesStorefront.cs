using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsSamplesStorefront
    {
        public int SampleId { get; set; }
        public short StorefrontId { get; set; }
        public decimal? InsertFeeToStorefront { get; set; }

        public virtual ProdsSample Sample { get; set; } = null!;
        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
