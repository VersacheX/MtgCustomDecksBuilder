using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontBrandInfo
    {
        public short StorefrontId { get; set; }
        public int BrandId { get; set; }
        public bool? DisableMapstrikeThrough { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
