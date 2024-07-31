using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TempJetSkusAvailable20160920
    {
        public int ProdId { get; set; }
        public string? Title { get; set; }
        public string? Status { get; set; }
        public string? Substatus { get; set; }
        public string? Inventory { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? MarkupPercent { get; set; }
        public decimal? EffectivePrice { get; set; }
        public decimal? EffectiveShipping { get; set; }
        public decimal? Ashprice { get; set; }
        public decimal? Ashshipping { get; set; }
        public int? Velocity30Days { get; set; }
    }
}
