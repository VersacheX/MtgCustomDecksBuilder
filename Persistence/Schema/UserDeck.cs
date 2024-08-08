using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class UserDeck
    {
        public UserDeck()
        {
            UserDeckCards = new HashSet<UserDeckCard>();
        }

        public int UserDeckPk { get; set; }
        public string? DeckName { get; set; }
        public int? UserFk { get; set; }
        public int? DeckRuleCriteriaFk { get; set; }

        public virtual DeckRuleCriterion? DeckRuleCriteriaFkNavigation { get; set; }
        public virtual User? UserFkNavigation { get; set; }
        public virtual ICollection<UserDeckCard> UserDeckCards { get; set; }
    }
}
