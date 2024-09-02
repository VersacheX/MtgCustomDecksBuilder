using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class UserDeckCard
    {
        public int UserDeckCardPk { get; set; }
        public int? UserDeckFk { get; set; }
        public int? MtgCardFk { get; set; }
        public int DeckLocationFk { get; set; }
        public bool? IsCommander { get; set; }
        public bool? IsCompanion { get; set; }

        public virtual DeckLocation DeckLocationFkNavigation { get; set; } = null!;
        public virtual MtgCard? MtgCardFkNavigation { get; set; }
        public virtual UserDeck? UserDeckFkNavigation { get; set; }
    }
}
