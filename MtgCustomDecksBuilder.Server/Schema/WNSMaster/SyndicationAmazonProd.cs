using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationAmazonProd
    {
        public int DetailId { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public bool Initialize { get; set; }
        public bool Hide { get; set; }
        public int MarketplaceId { get; set; }
        public string? AmazonCategory { get; set; }
        public string? Title { get; set; }
        public string? Manufacturer { get; set; }
        public string? Brand { get; set; }
        public string? Asin { get; set; }
        public string? Upc { get; set; }
        public string? ItemType { get; set; }
        public string? Description { get; set; }
        public string? Ingredients1 { get; set; }
        public string? Ingredients2 { get; set; }
        public string? Ingredients3 { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string? Flavor { get; set; }
        public string? Size { get; set; }
        public string? MainImageUrl { get; set; }
        public string? SearchTerms1 { get; set; }
        public string? SearchTerms2 { get; set; }
        public string? SearchTerms3 { get; set; }
        public string? SearchTerms4 { get; set; }
        public string? SearchTerms5 { get; set; }
        public decimal? ItemPriceObsolete { get; set; }
        public decimal? ShippingObsolete { get; set; }
        public string? Sku { get; set; }
        public short? CurrentInventory { get; set; }
        public short? Count { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
