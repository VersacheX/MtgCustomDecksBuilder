using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsCountryIngredientsExclusion
    {
        public int CountryId { get; set; }
        public string Ingredient { get; set; } = null!;
    }
}
