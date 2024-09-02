using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class DeckRuleCriterion
    {
        public DeckRuleCriterion()
        {
            DeckRuleCriteriaAllowedSets = new HashSet<DeckRuleCriteriaAllowedSet>();
            DeckRuleCriteriaSetTypes = new HashSet<DeckRuleCriteriaSetType>();
            UserDecks = new HashSet<UserDeck>();
        }

        public int DeckRuleCriterionPk { get; set; }
        public string? Name { get; set; }
        public int? MtgFormatFk { get; set; }
        public int? GameFormatFk { get; set; }
        public int? UserFk { get; set; }
        public int? LibraryCardCount { get; set; }
        public int? SideboardCount { get; set; }
        public bool? CommanderAllowed { get; set; }
        public bool? CompanionAllowed { get; set; }

        public virtual GameFormat? GameFormatFkNavigation { get; set; }
        public virtual MtgFormat? MtgFormatFkNavigation { get; set; }
        public virtual User? UserFkNavigation { get; set; }
        public virtual ICollection<DeckRuleCriteriaAllowedSet> DeckRuleCriteriaAllowedSets { get; set; }
        public virtual ICollection<DeckRuleCriteriaSetType> DeckRuleCriteriaSetTypes { get; set; }
        public virtual ICollection<UserDeck> UserDecks { get; set; }
    }
}
