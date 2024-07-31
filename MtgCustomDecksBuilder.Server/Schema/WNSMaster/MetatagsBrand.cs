using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MetatagsBrand
    {
        public short BrandId { get; set; }
        public short StorefrontId { get; set; }
        public int? Urlid { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? MetaKeywords { get; set; }
        public string? Content { get; set; }
        public string? InternalNotes { get; set; }
        public string? Header { get; set; }

        public virtual ProdsBrand Brand { get; set; } = null!;
        public virtual StorefrontInfo Storefront { get; set; } = null!;
        public virtual StandardUrl? Url { get; set; }
    }
}
