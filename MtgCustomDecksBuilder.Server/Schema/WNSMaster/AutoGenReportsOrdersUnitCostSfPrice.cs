using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsOrdersUnitCostSfPrice
    {
        public int? ProviderOrderId { get; set; }
        public int? StorefrontId { get; set; }
        public int? Ponum { get; set; }
        public int? ProdId { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? PriceToStorefront { get; set; }
        public decimal? PercentLoss { get; set; }
        public int? Qty { get; set; }
        public string? ProdName { get; set; }
        public int? ReportId { get; set; }
        public int? WrhsId { get; set; }
    }
}
