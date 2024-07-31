using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersRefillRemindersStatus
    {
        public OrdersRefillRemindersStatus()
        {
            OrdersRefillRemindersV2s = new HashSet<OrdersRefillRemindersV2>();
        }

        public byte StatusCode { get; set; }
        public string StatusDesc { get; set; } = null!;

        public virtual ICollection<OrdersRefillRemindersV2> OrdersRefillRemindersV2s { get; set; }
    }
}
