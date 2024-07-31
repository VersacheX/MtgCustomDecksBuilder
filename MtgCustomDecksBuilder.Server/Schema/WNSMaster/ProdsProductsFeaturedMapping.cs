using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsFeaturedMapping
    {
        public int FeaturedProdId { get; set; }
        public int ProdId { get; set; }
        public short StorefrontId { get; set; }
        public byte? Strength { get; set; }
    }
}
