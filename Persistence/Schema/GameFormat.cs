using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class GameFormat
    {
        public GameFormat()
        {
            DeckRuleCriteria = new HashSet<DeckRuleCriterion>();
        }

        public int GameFormatPk { get; set; }
        public string? Name { get; set; }
        public bool? CommanderLegal { get; set; }
        public bool? CompanionLegal { get; set; }
        public int? MinCardCount { get; set; }
        public int? MaxCardCount { get; set; }
        public int? SideboardSize { get; set; }
        public int? DuplicateCardLimit { get; set; }

        public virtual ICollection<DeckRuleCriterion> DeckRuleCriteria { get; set; }
    }
}
