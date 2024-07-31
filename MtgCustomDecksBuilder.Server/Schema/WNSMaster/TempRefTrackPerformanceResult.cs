using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TempRefTrackPerformanceResult
    {
        public string? Reftrackcode { get; set; }
        public int? Numofclicks { get; set; }
        public int? Numofsessions { get; set; }
        public int? Numofuniquevis { get; set; }
        public float? Numoforders { get; set; }
        public float? Conversionrate { get; set; }
        public decimal? Grossprofit { get; set; }
        public int? Prodid { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
    }
}
