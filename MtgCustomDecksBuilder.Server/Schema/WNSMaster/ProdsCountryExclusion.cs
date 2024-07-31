using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsCountryExclusion
    {
        public int ProdId { get; set; }
        public short CountryId { get; set; }
        public string AllowDisallow { get; set; } = null!;
        public string StateCode { get; set; } = null!;
    }
}
