using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingSagawaBillingImport
    {
        public OrdersProviderShippingSagawaBillingImport()
        {
            OrdersProviderShippingSagawaBillings = new HashSet<OrdersProviderShippingSagawaBilling>();
        }

        public int ImportId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<OrdersProviderShippingSagawaBilling> OrdersProviderShippingSagawaBillings { get; set; }
    }
}
