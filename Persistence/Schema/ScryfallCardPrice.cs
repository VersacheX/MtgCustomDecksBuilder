using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class ScryfallCardPrice
    {
        public int ScryfallCardPricesPk { get; set; }
        public int ScryfallCardFk { get; set; }
        public string? Usd { get; set; }
        public string? UsdFoil { get; set; }
        public string? UsdEtched { get; set; }
        public string? Eur { get; set; }
        public string? EurFoil { get; set; }
        public string? Tix { get; set; }

        public virtual ScryfallCard ScryfallCardFkNavigation { get; set; } = null!;
    }
}
