using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class ScryfallCardRelatedUri
    {
        public int ScryfallCardRelatedUrisPk { get; set; }
        public int ScryfallCardFk { get; set; }
        public string? Gatherer { get; set; }
        public string? TcgplayerInfiniteArticles { get; set; }
        public string? TcgplayerInfiniteDecks { get; set; }
        public string? Edhrec { get; set; }

        public virtual ScryfallCard ScryfallCardFkNavigation { get; set; } = null!;
    }
}
