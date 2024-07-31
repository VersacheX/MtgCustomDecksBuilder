using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AccountingSale
    {
        public int TransNum { get; set; }
        public DateTime TransTime { get; set; }
        public byte SalesTypeId { get; set; }
        public byte TransClassId { get; set; }
        public int? TaxId { get; set; }
        public int? TransNumTaxAppliesTo { get; set; }
        public decimal? UnitApproxAverageCost { get; set; }
        public decimal UnitSalePrice { get; set; }
        public int Qty { get; set; }
        public int? ProviderOrderId { get; set; }
        public int? ProdId { get; set; }
        public short? ProviderId { get; set; }
        public short? StorefrontId { get; set; }
        public string? Notes { get; set; }
        public decimal? CalculatedCostToProviderUpdatable { get; set; }
        public byte? CalculatedCostMethodId { get; set; }
        public DateTime? DateCostToProviderCalculated { get; set; }
    }
}
