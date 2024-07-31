using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersPlacedTaskType
    {
        public OrdersPlacedTaskType()
        {
            OrdersPlacedTasks = new HashSet<OrdersPlacedTask>();
        }

        public int Id { get; set; }
        public string? Type { get; set; }

        public virtual ICollection<OrdersPlacedTask> OrdersPlacedTasks { get; set; }
    }
}
