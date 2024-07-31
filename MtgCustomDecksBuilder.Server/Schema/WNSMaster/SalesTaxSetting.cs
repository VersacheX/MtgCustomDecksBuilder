using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SalesTaxSetting
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string CountryCode { get; set; } = null!;
        public string? StateCode { get; set; }
        public decimal? RateFood { get; set; }
        public decimal? RateSupplement { get; set; }
        public decimal? RateGeneral { get; set; }
        public bool? IsTaxOnShipping { get; set; }
        public bool? Use3rdPartyLookup { get; set; }
        public string? Notes { get; set; }
    }
}
