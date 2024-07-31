using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ShippingTransitTime
    {
        public byte WrhsId { get; set; }
        public string ToZip { get; set; } = null!;
        public int NumOfPackages { get; set; }
        public decimal? Mxobserved { get; set; }
        public decimal? Pmobserved { get; set; }
        public decimal? Fcobserved { get; set; }
        public decimal? Upsgroundobserved { get; set; }
        public decimal? BasicBrownobserved { get; set; }
        public decimal? BasicUspsobserved { get; set; }
        public decimal? Ngsstated { get; set; }
        public decimal? Ngsobserved { get; set; }
    }
}
