using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WalmartReportItem
    {
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
        public decimal? BuyBoxItemPrice { get; set; }
        public decimal? BuyBoxShippingPrice { get; set; }
        public string? PublishStatus { get; set; }
        public string? StatusChangeReason { get; set; }
        public string? LifecycleStatus { get; set; }
        public int? InventoryCount { get; set; }
        public string? ShipMethods { get; set; }
        public string? Wpid { get; set; }
        public string? ItemId { get; set; }
        public string? Gtin { get; set; }
        public string? Upc { get; set; }
        public int? ReviewsCount { get; set; }
        public decimal? AverageRating { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
