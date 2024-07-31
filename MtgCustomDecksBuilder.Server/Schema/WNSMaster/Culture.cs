using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Culture
    {
        public string CultureCode { get; set; } = null!;
        public byte? LangId { get; set; }
        public short? CurrencyId { get; set; }
        public short? CountryId { get; set; }
        public bool? IsAuthority { get; set; }
    }
}
