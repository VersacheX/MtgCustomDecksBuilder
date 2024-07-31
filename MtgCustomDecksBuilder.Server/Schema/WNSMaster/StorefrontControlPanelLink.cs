using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontControlPanelLink
    {
        public StorefrontControlPanelLink()
        {
            Storefronts = new HashSet<StorefrontInfo>();
        }

        public short LinkId { get; set; }
        public short ParentId { get; set; }
        public string Text { get; set; } = null!;
        public string? Url { get; set; }
        public byte? SortIndex { get; set; }

        public virtual ICollection<StorefrontInfo> Storefronts { get; set; }
    }
}
