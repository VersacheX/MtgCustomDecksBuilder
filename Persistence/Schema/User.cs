using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class User
    {
        public User()
        {
            DeckRuleCriteria = new HashSet<DeckRuleCriterion>();
            UserDecks = new HashSet<UserDeck>();
        }

        public int UserPk { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<DeckRuleCriterion> DeckRuleCriteria { get; set; }
        public virtual ICollection<UserDeck> UserDecks { get; set; }
    }
}
