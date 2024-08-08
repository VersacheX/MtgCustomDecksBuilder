using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class DeckRuleCriteriaAllowedSet
    {
        public int DeckRuleCriteriaAllowedSetPk { get; set; }
        public int? DeckRuleCriteriaFk { get; set; }
        public int? MtgSetFk { get; set; }

        public virtual DeckRuleCriterion? DeckRuleCriteriaFkNavigation { get; set; }
        public virtual MtgSet? MtgSetFkNavigation { get; set; }
    }
}
