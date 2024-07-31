using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WalmartPayment
    {
        public WalmartPayment()
        {
            WalmartPaymentLines = new HashSet<WalmartPaymentLine>();
        }

        public int Id { get; set; }
        public string? FileName { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<WalmartPaymentLine> WalmartPaymentLines { get; set; }
    }
}
