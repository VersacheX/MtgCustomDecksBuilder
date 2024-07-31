using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetOrderLineFeeAdjustment
    {
        public int Id { get; set; }
        public int JetOrderLineId { get; set; }
        public string? CommissionId { get; set; }
        public string? AdjustmentName { get; set; }
        public string? AdjustmentType { get; set; }
        public decimal? Value { get; set; }

        public virtual JetOrderLine JetOrderLine { get; set; } = null!;
    }
}
