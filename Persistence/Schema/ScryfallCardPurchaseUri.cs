using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class ScryfallCardPurchaseUri
    {
        public int ScryfallCardPurchaseUrisPk { get; set; }
        public int ScryfallCardFk { get; set; }
        public string? Tcgplayer { get; set; }
        public string? Cardmarket { get; set; }

        public virtual ScryfallCard ScryfallCardFkNavigation { get; set; } = null!;
    }
}
