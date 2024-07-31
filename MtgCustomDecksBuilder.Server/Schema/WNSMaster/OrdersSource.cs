using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersSource
    {
        public OrdersSource()
        {
            Orders = new HashSet<Order>();
        }

        public byte SourceId { get; set; }
        public string? SourceDesc { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
