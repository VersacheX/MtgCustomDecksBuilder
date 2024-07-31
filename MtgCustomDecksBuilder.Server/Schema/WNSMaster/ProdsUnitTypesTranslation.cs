using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsUnitTypesTranslation
    {
        public byte LangId { get; set; }
        public short UnitTypeId { get; set; }
        public string UnitTypeName { get; set; } = null!;
        public string? UnitTypeName2 { get; set; }
        public string? VariationTheme { get; set; }
    }
}
