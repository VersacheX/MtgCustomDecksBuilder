using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class KeywordsStandard
    {
        public KeywordsStandard()
        {
            KeywordsSpellingVariations = new HashSet<KeywordsSpellingVariation>();
            MetatagsKeywords = new HashSet<MetatagsKeyword>();
            Fams = new HashSet<ProdsFamily>();
        }

        public int KeywordId { get; set; }
        public string StandardString { get; set; } = null!;
        public DateTime? LastInfoChangeTimestamp { get; set; }

        public virtual ICollection<KeywordsSpellingVariation> KeywordsSpellingVariations { get; set; }
        public virtual ICollection<MetatagsKeyword> MetatagsKeywords { get; set; }

        public virtual ICollection<ProdsFamily> Fams { get; set; }
    }
}
