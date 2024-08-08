using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class MtgFormat
    {
        public MtgFormat()
        {
            DeckRuleCriteria = new HashSet<DeckRuleCriterion>();
        }

        public int MtgFormatPk { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<DeckRuleCriterion> DeckRuleCriteria { get; set; }
    }
}
