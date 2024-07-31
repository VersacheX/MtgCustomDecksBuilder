using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsProductsOver6Month
    {
        public int Prodid { get; set; }
        public string? Column1 { get; set; }
        public int? QtyInInventory { get; set; }
        public decimal? FourWeekVel { get; set; }
        public int? ReportId { get; set; }
        public decimal? Qty4WkVel { get; set; }
        public bool? UnusualVelocityExpected { get; set; }
    }
}
