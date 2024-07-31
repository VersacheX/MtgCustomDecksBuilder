using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsSupplementFactsTranslation
    {
        public byte LangId { get; set; }
        public int ProdId { get; set; }
        public short RowNum { get; set; }
        public byte TableIndex { get; set; }
        public string? Ingredient { get; set; }
        public string? AmtPerServ { get; set; }
        public string? PercentDv { get; set; }
    }
}
