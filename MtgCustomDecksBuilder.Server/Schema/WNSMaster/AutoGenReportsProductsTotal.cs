using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsProductsTotal
    {
        public decimal? CurAshpubPriceTot { get; set; }
        public decimal? StdAshpubPriceTot { get; set; }
        public decimal? StdCostToAltura { get; set; }
        public int? ReportId { get; set; }
        public decimal? ActualAlturaCost { get; set; }
        public decimal? CurAshpubPriceTotAdvantis { get; set; }
        public decimal? StdAshpubPriceTotAdvantis { get; set; }
        public decimal? StdCostToAdvantis { get; set; }
        public decimal? ActualAdvantisCost { get; set; }
    }
}
