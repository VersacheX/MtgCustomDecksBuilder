using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TaxLookupLine
    {
        public long Id { get; set; }
        public long TaxLookupId { get; set; }
        public decimal? TaxableAmount { get; set; }
        public decimal? TaxCollectable { get; set; }
        public decimal? CombinedTaxRate { get; set; }
        public decimal? StateTaxableAmount { get; set; }
        public decimal? StateTaxRate { get; set; }
        public decimal? StateAmount { get; set; }
        public decimal? CountyTaxableAmount { get; set; }
        public decimal? CountyTaxRate { get; set; }
        public decimal? CountyAmount { get; set; }
        public decimal? CityTaxableAmount { get; set; }
        public decimal? CityTaxRate { get; set; }
        public decimal? CityAmount { get; set; }
        public decimal? SpecialDistrictTaxableAmount { get; set; }
        public decimal? SpecialDistrictTaxRate { get; set; }
        public decimal? SpecialDistrictAmount { get; set; }

        public virtual TaxLookup TaxLookup { get; set; } = null!;
    }
}
