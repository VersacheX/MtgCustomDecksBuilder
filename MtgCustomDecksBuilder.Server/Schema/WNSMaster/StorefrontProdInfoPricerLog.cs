using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontProdInfoPricerLog
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public int? ProdId { get; set; }
        public string? Upc { get; set; }
        public int? Ash28dayVelocity { get; set; }
        public int? AshpricePosition { get; set; }
        public decimal? StdPubPrice { get; set; }
        public decimal? CurPubPrice { get; set; }
        public decimal? AvgEdlp { get; set; }
        public decimal? AvgCost { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? MarkupAmount { get; set; }
        public decimal? MarkupPercent { get; set; }
        public decimal? MinimumPrice { get; set; }
        public decimal? LowestGoogleTotalPrice { get; set; }
        public decimal? NewCalculatedPrice { get; set; }
        public bool? PriceIsUpdated { get; set; }
        public DateTime DateInserted { get; set; }
    }
}
