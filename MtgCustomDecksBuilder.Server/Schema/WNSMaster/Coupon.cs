using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Coupon
    {
        public Coupon()
        {
            CouponsProdAddToCarts = new HashSet<CouponsProdAddToCart>();
            CouponsProdGroups = new HashSet<CouponsProdGroup>();
        }

        public int CouponId { get; set; }
        public string CouponCode { get; set; } = null!;
        public short StorefrontId { get; set; }
        public string AbsOrPerc { get; set; } = null!;
        public decimal Amount { get; set; }
        public string CouponDesc { get; set; } = null!;
        public decimal? MinEnableAmount { get; set; }
        public DateTime? Starts { get; set; }
        public DateTime Expires { get; set; }
        public bool? IsOneTimeUse { get; set; }
        public string? CouponAppliedMessage { get; set; }
        public string? CouponNotAppliedMessage { get; set; }
        public bool? DisplayToPublic { get; set; }
        public DateTime LastModified { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
        public virtual ICollection<CouponsProdAddToCart> CouponsProdAddToCarts { get; set; }
        public virtual ICollection<CouponsProdGroup> CouponsProdGroups { get; set; }
    }
}
