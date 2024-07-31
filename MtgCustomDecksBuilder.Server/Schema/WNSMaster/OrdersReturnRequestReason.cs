using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersReturnRequestReason
    {
        public OrdersReturnRequestReason()
        {
            OrdersReturnRequests = new HashSet<OrdersReturnRequest>();
        }

        public int Id { get; set; }
        public string Reason { get; set; } = null!;
        public bool IsBuyerFault { get; set; }

        public virtual ICollection<OrdersReturnRequest> OrdersReturnRequests { get; set; }
    }
}
