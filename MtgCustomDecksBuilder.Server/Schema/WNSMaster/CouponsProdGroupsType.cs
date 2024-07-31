using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CouponsProdGroupsType
    {
        public CouponsProdGroupsType()
        {
            CouponsProdGroups = new HashSet<CouponsProdGroup>();
        }

        public byte GroupTypeId { get; set; }
        public string GroupDesc { get; set; } = null!;

        public virtual ICollection<CouponsProdGroup> CouponsProdGroups { get; set; }
    }
}
