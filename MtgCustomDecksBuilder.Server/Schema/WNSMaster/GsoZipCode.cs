using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GsoZipCode
    {
        public string Zip { get; set; } = null!;
        public byte CoverageArea { get; set; }
        public int? TransitDays { get; set; }
        public int? Zone { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
    }
}
