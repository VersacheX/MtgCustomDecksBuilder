using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersPlacedTask
    {
        public long Id { get; set; }
        public int ProviderOrderId { get; set; }
        public int TypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ProcessingOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? ErredOn { get; set; }
        public int? ErrorCount { get; set; }
        public string? ErrorMsg { get; set; }
        public string? Parameters { get; set; }
        public DateTime? ScheduledOn { get; set; }

        public virtual OrdersProvider ProviderOrder { get; set; } = null!;
        public virtual OrdersPlacedTaskType Type { get; set; } = null!;
    }
}
