using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsTranslationsOverride
    {
        public byte LangId { get; set; }
        public int ProdId { get; set; }
        public string? MfgDesc { get; set; }
        public string? MfgFactNotes { get; set; }
        public string? MfgDirections { get; set; }
        public string? MfgDisclaimer { get; set; }
        public string? MfgIngredients { get; set; }
    }
}
