using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class MtgSet
    {
        public MtgSet()
        {
            DeckRuleCriteriaAllowedSets = new HashSet<DeckRuleCriteriaAllowedSet>();
            DeckRuleCriteriaSetTypes = new HashSet<DeckRuleCriteriaSetType>();
            MtgCardSets = new HashSet<MtgCardSet>();
        }

        public int MtgSetPk { get; set; }
        public string? Name { get; set; }
        public string? Expansion { get; set; }
        public string? Code { get; set; }
        public string? Block { get; set; }
        public string? Type { get; set; }
        public bool? OnlineOnly { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public virtual ICollection<DeckRuleCriteriaAllowedSet> DeckRuleCriteriaAllowedSets { get; set; }
        public virtual ICollection<DeckRuleCriteriaSetType> DeckRuleCriteriaSetTypes { get; set; }
        public virtual ICollection<MtgCardSet> MtgCardSets { get; set; }
    }
}
