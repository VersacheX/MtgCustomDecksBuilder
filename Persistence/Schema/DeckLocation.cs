using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class DeckLocation
    {
        public DeckLocation()
        {
            UserDeckCards = new HashSet<UserDeckCard>();
        }

        public int DeckLocationPk { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<UserDeckCard> UserDeckCards { get; set; }
    }
}
