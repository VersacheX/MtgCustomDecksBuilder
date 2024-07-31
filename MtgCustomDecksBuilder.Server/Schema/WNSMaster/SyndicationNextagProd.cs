using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationNextagProd
    {
        public int DetailId { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public bool Initialize { get; set; }
        public bool Hide { get; set; }
        public string? NextagCategory { get; set; }
        public string? RefTrack { get; set; }
        public string? BrandName { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? Availability { get; set; }
        public string? ProductUrl { get; set; }
        public string? ImageUrl { get; set; }
        public string? Upc { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
