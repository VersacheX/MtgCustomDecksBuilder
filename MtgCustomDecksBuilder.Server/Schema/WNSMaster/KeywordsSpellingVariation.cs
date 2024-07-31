using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class KeywordsSpellingVariation
    {
        public int KeywordId { get; set; }
        public string StringVariation { get; set; } = null!;

        public virtual KeywordsStandard Keyword { get; set; } = null!;
    }
}
