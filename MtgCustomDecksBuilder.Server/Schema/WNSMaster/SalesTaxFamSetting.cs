using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SalesTaxFamSetting
    {
        public long Id { get; set; }
        public short StorefrontId { get; set; }
        public short CountryId { get; set; }
        public string StateCode { get; set; } = null!;
        public int FamId { get; set; }
        public bool? IsFood { get; set; }
        public bool? IsSupplement { get; set; }
        public string? TaxJarCategoryCode { get; set; }
    }
}
