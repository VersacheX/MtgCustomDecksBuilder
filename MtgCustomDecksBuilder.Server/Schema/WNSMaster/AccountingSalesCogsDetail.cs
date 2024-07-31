using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AccountingSalesCogsDetail
    {
        public long Uniquefier { get; set; }
        public int AccountingSalesTransNum { get; set; }
        public int Ponum { get; set; }
        public int Qty { get; set; }
        public decimal? GrossUnitCost { get; set; }
        public decimal? RebatePercent { get; set; }
        public string? CostDetermination { get; set; }
    }
}
