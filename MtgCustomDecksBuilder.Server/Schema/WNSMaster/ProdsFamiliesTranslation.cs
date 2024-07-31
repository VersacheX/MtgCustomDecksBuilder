using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsFamiliesTranslation
    {
        public byte LangId { get; set; }
        public int FamId { get; set; }
        public string FamName { get; set; } = null!;
        public string? FamName2 { get; set; }
        public string? ShortDesc { get; set; }
        public string? DetailedDesc { get; set; }

        public virtual Language Lang { get; set; } = null!;
    }
}
