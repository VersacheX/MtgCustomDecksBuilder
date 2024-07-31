using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            MarketingPreferences = new HashSet<MarketingPreference>();
            Orders = new HashSet<Order>();
            UserAccountsNotes = new HashSet<UserAccountsNote>();
        }

        public int AccountId { get; set; }
        public short StorefrontId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public string? ScreenName { get; set; }
        public string? Btitle { get; set; }
        public string? Bfname { get; set; }
        public string? Bmname { get; set; }
        public string? Blname { get; set; }
        public string? Baddress { get; set; }
        public string? Baddress2 { get; set; }
        public string? Bcity { get; set; }
        public string? Bstate { get; set; }
        public string? Bzip { get; set; }
        public string? Bcountry { get; set; }
        public string? Bphone { get; set; }
        public string? Bemail { get; set; }
        public string? Stitle { get; set; }
        public string? Sfname { get; set; }
        public string? Smname { get; set; }
        public string? Slname { get; set; }
        public string? Saddress { get; set; }
        public string? Saddress2 { get; set; }
        public string? Scity { get; set; }
        public string? Sstate { get; set; }
        public string? Szip { get; set; }
        public short? ScountryId { get; set; }
        public string? Sphone { get; set; }
        public string? Semail { get; set; }
        public bool? CcinfoFaxOnFile { get; set; }
        public string? CctypeCode { get; set; }
        public string? NameAsOnCc { get; set; }
        public string? CcnumberObsolete { get; set; }
        public string? CcexpMonth { get; set; }
        public string? CcexpYear { get; set; }
        public bool? CheckNotesBeforeShipping { get; set; }
        public bool? InsuranceRequired { get; set; }
        public DateTime LastModified { get; set; }
        public byte[]? CcnumberEnc { get; set; }
        public bool? NoSticker { get; set; }
        public string? PayTechCustRefNum { get; set; }
        public bool? NoProp65Sticker { get; set; }
        public bool? IsTaxExempt { get; set; }
        public DateTime? LastTaxLookupOn { get; set; }
        public string? TaxStateName { get; set; }
        public decimal? TaxStateRateGeneral { get; set; }
        public decimal? TaxStateRateFood { get; set; }
        public decimal? TaxStateRateSupplement { get; set; }
        public decimal? TaxStateRateShipping { get; set; }
        public string? TaxCountyName { get; set; }
        public decimal? TaxCountyRateGeneral { get; set; }
        public decimal? TaxCountyRateFood { get; set; }
        public decimal? TaxCountyRateSupplement { get; set; }
        public decimal? TaxCountyRateShipping { get; set; }
        public string? TaxCityName { get; set; }
        public decimal? TaxCityRateGeneral { get; set; }
        public decimal? TaxCityRateFood { get; set; }
        public decimal? TaxCityRateSupplement { get; set; }
        public decimal? TaxCityRateShipping { get; set; }
        public string? TaxDistrictName { get; set; }
        public decimal? TaxDistrictRateGeneral { get; set; }
        public decimal? TaxDistrictRateFood { get; set; }
        public decimal? TaxDistrictRateSupplement { get; set; }
        public decimal? TaxDistrictRateShipping { get; set; }
        public bool? IsTaxOnShipping { get; set; }
        public string? TaxCountryName { get; set; }
        public decimal? TaxCountryRateGeneral { get; set; }
        public decimal? TaxCountryRateFood { get; set; }
        public decimal? TaxCountryRateSupplement { get; set; }
        public decimal? TaxCountryRateShipping { get; set; }
        public bool? IsWillCallEnabled { get; set; }
        public string? SavedCartId { get; set; }
        public string? SphoneFiltered { get; set; }
        public string? BphoneFiltered { get; set; }

        public virtual ICollection<MarketingPreference> MarketingPreferences { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserAccountsNote> UserAccountsNotes { get; set; }
    }
}
