using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TaxLookup
    {
        public TaxLookup()
        {
            TaxLookupLines = new HashSet<TaxLookupLine>();
        }

        public long Id { get; set; }
        public decimal? OrderTotalAmount { get; set; }
        public decimal? Shipping { get; set; }
        public decimal? AmountTaxable { get; set; }
        public decimal? AmountToCollect { get; set; }
        public decimal? Rate { get; set; }
        public bool? HasNexus { get; set; }
        public bool? FreightTaxable { get; set; }
        public string? TaxSource { get; set; }
        public string? ExemptionType { get; set; }
        public string? JurisdictionCountry { get; set; }
        public string? JurisdictionState { get; set; }
        public string? JurisdictionCounty { get; set; }
        public string? JurisdictionCity { get; set; }
        public decimal? TaxableAmount { get; set; }
        public decimal? TaxCollectable { get; set; }
        public decimal? CombinedTaxRate { get; set; }
        public decimal? StateTaxableAmount { get; set; }
        public decimal? StateTaxRate { get; set; }
        public decimal? StateTaxCollectable { get; set; }
        public decimal? CountyTaxableAmount { get; set; }
        public decimal? CountyTaxRate { get; set; }
        public decimal? CountyTaxCollectable { get; set; }
        public decimal? CityTaxableAmount { get; set; }
        public decimal? CityTaxRate { get; set; }
        public decimal? CityTaxCollectable { get; set; }
        public decimal? SpecialDistrictTaxableAmount { get; set; }
        public decimal? SpecialDistrictTaxRate { get; set; }
        public decimal? SpecialDistrictTaxCollectable { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<TaxLookupLine> TaxLookupLines { get; set; }
    }
}
