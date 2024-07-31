using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsCountryIngredientsExclusionsNote
    {
        public int CountryId { get; set; }
        public string Notes { get; set; } = null!;
    }
}
