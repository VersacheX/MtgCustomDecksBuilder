using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontsPubSiteKeywordRedirect
    {
        public int Id { get; set; }
        public string Keyword { get; set; } = null!;
        public string Url { get; set; } = null!;
    }
}
