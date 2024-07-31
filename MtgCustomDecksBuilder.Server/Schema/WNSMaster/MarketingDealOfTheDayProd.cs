using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MarketingDealOfTheDayProd
    {
        public int DealProdId { get; set; }
        public int DealId { get; set; }
        public int ProdId { get; set; }
        public decimal? OldCurPubPrice { get; set; }
        public decimal DealCurPubPrice { get; set; }
        public int? OldMaxShoppingCartUnits { get; set; }
        public int? DealMaxShoppingCartUnits { get; set; }
        public bool IsPrimary { get; set; }
        public int? EndDealAtQtyInInventory { get; set; }
        public int? DisplayIndex { get; set; }
        public DateTime CreatedOnDateTime { get; set; }

        public virtual MarketingDealOfTheDay Deal { get; set; } = null!;
    }
}
