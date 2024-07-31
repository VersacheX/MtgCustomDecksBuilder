using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ZipCodeDatum
    {
        public string ZipCode { get; set; } = null!;
        public string? City { get; set; }
        public string? County { get; set; }
        public string? State { get; set; }
    }
}
