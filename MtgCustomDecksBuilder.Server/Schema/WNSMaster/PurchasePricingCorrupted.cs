using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchasePricingCorrupted
    {
        public int ProdId { get; set; }
        public short VendorId { get; set; }
        public short ProviderId { get; set; }
        public decimal? EverydayLowPrice { get; set; }
        public decimal? EverydayRebatePercent { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialPriceBeg { get; set; }
        public DateTime? SpecialPriceExp { get; set; }
        public string? VendorSku { get; set; }
    }
}
