using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsAlturaPriceSpPrice
    {
        public string? LegalName { get; set; }
        public int ProdId { get; set; }
        public string? Column1 { get; set; }
        public decimal? Msrp { get; set; }
        public decimal? StdPubPrice { get; set; }
        public decimal? CurPubPrice { get; set; }
        public decimal? PriceToStorefront { get; set; }
        public decimal? AvgCostToAltura { get; set; }
        public int? ReportId { get; set; }
    }
}
