using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CouponsProdGroup
    {
        public int CouponId { get; set; }
        public byte GroupTypeId { get; set; }
        public int GroupValue { get; set; }

        public virtual Coupon Coupon { get; set; } = null!;
        public virtual CouponsProdGroupsType GroupType { get; set; } = null!;
    }
}
