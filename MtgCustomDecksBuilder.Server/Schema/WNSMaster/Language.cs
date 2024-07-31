using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Language
    {
        public Language()
        {
            ProdsFamiliesTranslations = new HashSet<ProdsFamiliesTranslation>();
        }

        public byte LangId { get; set; }
        public string LanguageName { get; set; } = null!;
        public string? LanguageLocalizedName { get; set; }

        public virtual ICollection<ProdsFamiliesTranslation> ProdsFamiliesTranslations { get; set; }
    }
}
