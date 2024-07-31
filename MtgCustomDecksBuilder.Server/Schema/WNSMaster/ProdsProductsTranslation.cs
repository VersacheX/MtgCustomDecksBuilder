using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsTranslation
    {
        public byte LangId { get; set; }
        public int ProdId { get; set; }
        public string? FamNameSuffix { get; set; }
        public string? FamNameSuffix2 { get; set; }
        public string? ServingUnit { get; set; }
        public string? ShortDesc { get; set; }
        public string? DetailedDesc { get; set; }
        public string? PopupNoteToConsumer { get; set; }
        public string? Prop65 { get; set; }
        public DateTime? Prop65ImportedOn { get; set; }
    }
}
