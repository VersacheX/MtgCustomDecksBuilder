using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Cart
    {
        public Cart()
        {
            CartsGiftCertificates = new HashSet<CartsGiftCertificate>();
            CartsLineItems = new HashSet<CartsLineItem>();
            CartsProductViews = new HashSet<CartsProductView>();
        }

        public string CartId { get; set; } = null!;
        public short? StorefrontId { get; set; }
        public int? AccountId { get; set; }
        public string? SessionId { get; set; }
        public byte UserAuthenticated { get; set; }
        public string? SubmittedUsername { get; set; }
        public string? SubmittedPassword { get; set; }
        public string? SubmittedPassword2 { get; set; }
        public string? BillToTitle { get; set; }
        public string? BillToFname { get; set; }
        public string? BillToMname { get; set; }
        public string? BillToLname { get; set; }
        public string? BillToAddress { get; set; }
        public string? BillToAddress2 { get; set; }
        public string? BillToCity { get; set; }
        public string? BillToState { get; set; }
        public string? BillToZip { get; set; }
        public string? BillToCountry { get; set; }
        public string? BillToPhone { get; set; }
        public string? BillToEmail { get; set; }
        public string? ShipToTitle { get; set; }
        public string? ShipToFname { get; set; }
        public string? ShipToMname { get; set; }
        public string? ShipToLname { get; set; }
        public string? ShipToAddress { get; set; }
        public string? ShipToAddress2 { get; set; }
        public string? ShipToCity { get; set; }
        public string? ShipToState { get; set; }
        public string? ShipToZip { get; set; }
        public short? ShipToCountryId { get; set; }
        public string? ShipToPhone { get; set; }
        public string? ShipToEmail { get; set; }
        public string? CouponCode { get; set; }
        public string? CouponAbsOrPerc { get; set; }
        public decimal? CouponAmount { get; set; }
        public DateTime? CouponExpires { get; set; }
        public string? CouponDesc { get; set; }
        public string? ShipZoneZip { get; set; }
        public int? ShipMethodId { get; set; }
        public string? CustomerComments { get; set; }
        public string? PaymentMethod { get; set; }
        public string? CctypeCode { get; set; }
        public string? NameAsOnCc { get; set; }
        public string? CcnumberObsolete { get; set; }
        public string? CcexpMonth { get; set; }
        public string? CcexpYear { get; set; }
        public bool? AbandonMsgSent { get; set; }
        public bool? IsNewCart { get; set; }
        public DateTime? LastModified { get; set; }
        public byte[]? CcnumberEnc { get; set; }
        public string? PayTechCustRefNum { get; set; }
        public int? UserAgentId { get; set; }
        public string? PayPalNonce { get; set; }
        public int? CouponStatusId { get; set; }
        public int? CouponId { get; set; }
        public decimal? CouponAppliedAmount { get; set; }
        public decimal? CouponAmountLeftToEnable { get; set; }
        public string? TaxStateName { get; set; }
        public decimal? TaxStateRateGeneral { get; set; }
        public decimal? TaxStateRateFood { get; set; }
        public decimal? TaxStateRateSupplement { get; set; }
        public string? TaxCountyName { get; set; }
        public decimal? TaxCountyRateGeneral { get; set; }
        public decimal? TaxCountyRateFood { get; set; }
        public decimal? TaxCountyRateSupplement { get; set; }
        public string? TaxCityName { get; set; }
        public decimal? TaxCityRateGeneral { get; set; }
        public decimal? TaxCityRateFood { get; set; }
        public decimal? TaxCityRateSupplement { get; set; }
        public string? TaxDistrictName { get; set; }
        public decimal? TaxDistrictRateGeneral { get; set; }
        public decimal? TaxDistrictRateFood { get; set; }
        public decimal? TaxDistrictRateSupplement { get; set; }
        public bool? IsTaxOnShipping { get; set; }
        public decimal? TaxStateRateShipping { get; set; }
        public decimal? TaxCountyRateShipping { get; set; }
        public decimal? TaxCityRateShipping { get; set; }
        public decimal? TaxDistrictRateShipping { get; set; }
        public bool? ShipToIsGift { get; set; }
        public bool? IsTaxExempt { get; set; }
        public bool? IsConsentToCookies { get; set; }
        public string? TaxCountryName { get; set; }
        public decimal? TaxCountryRateGeneral { get; set; }
        public decimal? TaxCountryRateFood { get; set; }
        public decimal? TaxCountryRateSupplement { get; set; }
        public decimal? TaxCountryRateShipping { get; set; }
        public bool? IsWillCallEnabled { get; set; }

        public virtual ICollection<CartsGiftCertificate> CartsGiftCertificates { get; set; }
        public virtual ICollection<CartsLineItem> CartsLineItems { get; set; }
        public virtual ICollection<CartsProductView> CartsProductViews { get; set; }
    }
}
