using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AffiliatesPayment
    {
        public int PaymentId { get; set; }
        public int AffiliateId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public int? CheckNumber { get; set; }

        public virtual Affiliate Affiliate { get; set; } = null!;
    }
}
