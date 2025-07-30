using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class ScryfallCardImageUri
    {
        public int ScryfallCardImageUrisPk { get; set; }
        public int ScryfallCardFk { get; set; }
        public string? Small { get; set; }
        public string? Normal { get; set; }
        public string? Large { get; set; }
        public string? Png { get; set; }
        public string? ArtCrop { get; set; }
        public string? BorderCrop { get; set; }

        public virtual ScryfallCard ScryfallCardFkNavigation { get; set; } = null!;
    }
}
