using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class LaserShipZipCode
    {
        public string Zip { get; set; } = null!;
        public byte Zone { get; set; }
        public byte TimeInTransit { get; set; }
        public string SortCode { get; set; } = null!;
        public byte CoverageArea { get; set; }
    }
}
