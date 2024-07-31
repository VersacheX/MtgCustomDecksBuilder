using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsExt1Translation
    {
        public byte LangId { get; set; }
        public int ProdId { get; set; }
        public string? MfgDesc { get; set; }
        public string? MfgDirections { get; set; }
    }
}
