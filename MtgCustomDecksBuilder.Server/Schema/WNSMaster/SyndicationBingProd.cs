using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationBingProd
    {
        public int DetailId { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public bool Initialize { get; set; }
        public bool Hide { get; set; }
        public string? RefTrack { get; set; }
        public string? Title { get; set; }
        public string? Brand { get; set; }
        public string? Link { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public string? ImageLink { get; set; }
        public string? Mpn { get; set; }
        public string? Gtin { get; set; }
        public bool? Adult { get; set; }
        public string? Availability { get; set; }
        public string? ProductCategory { get; set; }
        public string? Condition { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? Multipack { get; set; }
        public string? ProductType { get; set; }
        public string? MobileLink { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime? SalePriceEffectiveDate { get; set; }
        public string? BingAdsGrouping { get; set; }
        public string? BingAdsLabel { get; set; }
        public string? BingAdsRedirect { get; set; }
        public string? CustomLabel0 { get; set; }
        public string? CustomLabel1 { get; set; }
        public string? CustomLabel2 { get; set; }
        public string? CustomLabel3 { get; set; }
        public string? CustomLabel4 { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
