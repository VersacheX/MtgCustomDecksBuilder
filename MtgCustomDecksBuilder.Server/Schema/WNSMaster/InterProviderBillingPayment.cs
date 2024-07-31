using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class InterProviderBillingPayment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDateTime { get; set; }
        public short FromProviderId { get; set; }
        public short ToProviderId { get; set; }
        public decimal PaymentAmount { get; set; }
        public string? PaymentNotes { get; set; }

        public virtual Provider FromProvider { get; set; } = null!;
        public virtual Provider ToProvider { get; set; } = null!;
    }
}
