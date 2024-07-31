using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationBizRateProd
    {
        public int DetailId { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public bool Initialize { get; set; }
        public bool Hide { get; set; }
        public string? BizRateCategory { get; set; }
        public string? RefTrack { get; set; }
        public string? BrandName { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? ShippingCost { get; set; }
        public string? ProductUrl { get; set; }
        public string? ImageUrl { get; set; }
        public string? Upc { get; set; }
        public string? StockStatus { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
