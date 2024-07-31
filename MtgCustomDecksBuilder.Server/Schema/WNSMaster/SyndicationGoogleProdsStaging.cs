using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationGoogleProdsStaging
    {
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public short GoogleCountryId { get; set; }
        public string? GoogleProductType { get; set; }
        public string? Brand { get; set; }
        public string? Title { get; set; }
        public string? Color { get; set; }
        public string? Condition { get; set; }
        public string? Description { get; set; }
        public string? ExpirationDate { get; set; }
        public string? Id { get; set; }
        public string? ImageLink { get; set; }
        public string? Link { get; set; }
        public decimal? Price { get; set; }
        public string? Size { get; set; }
        public string? Gtin { get; set; }
        public string? Mpn { get; set; }
        public string? Weight { get; set; }
        public string? Availability { get; set; }
        public string? ShippingCountry { get; set; }
        public string? ShippingRegion { get; set; }
        public string? ShippingService { get; set; }
        public decimal? ShippingPrice { get; set; }
        public string? TaxCountry { get; set; }
        public string? TaxRegion { get; set; }
        public decimal? TaxPercent { get; set; }
        public string? TaxShip { get; set; }
        public string? CustomLabel0 { get; set; }
        public string? CustomLabel1 { get; set; }
        public string? CustomLabel2 { get; set; }
        public string? CustomLabel3 { get; set; }
        public string? CustomLabel4 { get; set; }
        public DateTime DateAdded { get; set; }
        public int? Available { get; set; }
        public bool? IncludeInBuyOnGoogle { get; set; }
        public string? Prop65 { get; set; }
    }
}
