using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersActionsLog
    {
        public int RecordId { get; set; }
        public int ProviderOrderId { get; set; }
        public short ActionId { get; set; }
        public string? Description { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
