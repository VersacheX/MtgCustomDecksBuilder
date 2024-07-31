using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PickupGroup
    {
        public PickupGroup()
        {
            PickupGroupsMappings = new HashSet<PickupGroupsMapping>();
        }

        public byte GroupId { get; set; }
        public string GroupDescription { get; set; } = null!;
        public byte? SortIndex { get; set; }
        public bool? IsInactive { get; set; }

        public virtual ICollection<PickupGroupsMapping> PickupGroupsMappings { get; set; }
    }
}
