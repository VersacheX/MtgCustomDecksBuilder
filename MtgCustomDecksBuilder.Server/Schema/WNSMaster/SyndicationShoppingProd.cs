using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationShoppingProd
    {
        public int DetailId { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public bool Initialize { get; set; }
        public bool Hide { get; set; }
        public string? ShoppingCategory { get; set; }
        public string? RefTrack { get; set; }
        public string? Mpn { get; set; }
        public string? ManufacturerName { get; set; }
        public string? Upc { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? Stock { get; set; }
        public string? StockDescription { get; set; }
        public string? ProductUrl { get; set; }
        public string? ImageUrl { get; set; }
        public decimal? ShippingRate { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
