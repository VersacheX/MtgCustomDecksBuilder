using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DhlGlobalMailRatesParcelPriority
    {
        public int ZoneNumber { get; set; }
        public string Destination { get; set; } = null!;
        public decimal PerItem { get; set; }
        public decimal PerPound { get; set; }
    }
}
