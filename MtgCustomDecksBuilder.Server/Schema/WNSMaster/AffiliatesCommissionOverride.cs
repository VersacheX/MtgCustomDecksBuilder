using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AffiliatesCommissionOverride
    {
        public int OverrideId { get; set; }
        public int AffiliateId { get; set; }
        public int ProdId { get; set; }
        public decimal? CommissionPercent { get; set; }
        public short? ReturnDays { get; set; }

        public virtual Affiliate Affiliate { get; set; } = null!;
    }
}
