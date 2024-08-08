using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class DeckRuleCriteriaSetType
    {
        public int DeckRuleCriteriaSetTypePk { get; set; }
        public int? DeckRuleCriteriaFk { get; set; }
        public int? SetTypeFk { get; set; }

        public virtual DeckRuleCriterion? DeckRuleCriteriaFkNavigation { get; set; }
        public virtual MtgSet? SetTypeFkNavigation { get; set; }
    }
}
