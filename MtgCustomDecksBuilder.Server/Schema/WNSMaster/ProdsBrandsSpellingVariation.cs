using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsBrandsSpellingVariation
    {
        public short BrandId { get; set; }
        public string StringVariation { get; set; } = null!;

        public virtual ProdsBrand Brand { get; set; } = null!;
    }
}
