using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsExt3Translation
    {
        public byte LangId { get; set; }
        public int ProdId { get; set; }
        public string? DescMarkerInfo { get; set; }
    }
}
