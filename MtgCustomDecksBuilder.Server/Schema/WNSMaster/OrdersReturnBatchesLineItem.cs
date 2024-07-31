using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersReturnBatchesLineItem
    {
        public int LineId { get; set; }
        public int BatchId { get; set; }
        public int ProviderOrderId { get; set; }
        public int ProdId { get; set; }
        public short QtyReturned { get; set; }
        public string ReturnTo { get; set; } = null!;
        public DateTime DateAndTime { get; set; }
        public DateTime? DateAndTimeSubmitted { get; set; }
    }
}
