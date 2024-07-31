using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CouponsProdAddToCart
    {
        public int RowId { get; set; }
        public int CouponId { get; set; }
        public int ProdId { get; set; }
        public short Qty { get; set; }

        public virtual Coupon Coupon { get; set; } = null!;
    }
}
