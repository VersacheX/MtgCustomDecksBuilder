using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationAmazonProdAdsProd
    {
        public int DetailId { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public bool Initialize { get; set; }
        public bool Hide { get; set; }
        public string? GoogleProductType { get; set; }
        public string? RefTrack { get; set; }
        public string? Brand { get; set; }
        public string? Color { get; set; }
        public string? Condition { get; set; }
        public string? Description { get; set; }
        public string? ExpirationDate { get; set; }
        public string? Format { get; set; }
        public string? Id { get; set; }
        public string? ImageLink { get; set; }
        public string? Link { get; set; }
        public string? ModelNumber { get; set; }
        public string? PaymentAccepted { get; set; }
        public string? PaymentNotes { get; set; }
        public string? Pickup { get; set; }
        public decimal? Price { get; set; }
        public string? PriceType { get; set; }
        public string? Quantity { get; set; }
        public string? Shipping { get; set; }
        public string? Size { get; set; }
        public string? TaxPercent { get; set; }
        public string? TaxRegion { get; set; }
        public string? Title { get; set; }
        public string? Upc { get; set; }
        public string? Mpn { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
