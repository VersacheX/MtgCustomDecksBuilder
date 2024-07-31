using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GsoZipCodesOriginal
    {
        public string Zip { get; set; } = null!;
        public byte CoverageArea { get; set; }
        public int? TransitDays { get; set; }
        public int? Zone { get; set; }
    }
}
