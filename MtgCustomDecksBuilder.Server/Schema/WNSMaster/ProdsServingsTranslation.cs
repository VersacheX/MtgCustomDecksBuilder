using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsServingsTranslation
    {
        public byte LangId { get; set; }
        public int ProdId { get; set; }
        public byte TableIndex { get; set; }
        public string? Header { get; set; }
        public decimal? ServingSize { get; set; }
        public decimal? ServingsPerContainer { get; set; }
        public string? ServingUnit { get; set; }
    }
}
