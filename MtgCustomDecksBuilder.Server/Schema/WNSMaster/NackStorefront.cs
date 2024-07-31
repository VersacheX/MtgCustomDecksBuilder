using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class NackStorefront
    {
        public short StorefrontId { get; set; }
        public decimal DefaultMarkupPercent { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
