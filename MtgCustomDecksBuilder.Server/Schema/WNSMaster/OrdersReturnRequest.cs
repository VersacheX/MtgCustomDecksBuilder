using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersReturnRequest
    {
        public OrdersReturnRequest()
        {
            OrdersReturnRequestLines = new HashSet<OrdersReturnRequestLine>();
        }

        public int Id { get; set; }
        public int ProviderOrderId { get; set; }
        public int ReasonId { get; set; }
        public string? RefundType { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public string? CustomerNotes { get; set; }
        public byte? CarrierId { get; set; }
        public string? TrackingNumber { get; set; }
        public string? Label { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public DateTime? DeniedOn { get; set; }

        public virtual OrdersReturnRequestReason Reason { get; set; } = null!;
        public virtual ICollection<OrdersReturnRequestLine> OrdersReturnRequestLines { get; set; }
    }
}
