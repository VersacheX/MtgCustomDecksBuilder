using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersBatchesPrinting
    {
        public OrdersBatchesPrinting()
        {
            LineItemRows = new HashSet<OrdersProviderLineItem>();
        }

        public int BatchId { get; set; }
        public short AdminId { get; set; }
        public byte? BatchStatusObsolete { get; set; }
        public string? Carrier { get; set; }
        public DateTime DateAndTime { get; set; }
        public short? StorefrontId { get; set; }

        public virtual ICollection<OrdersProviderLineItem> LineItemRows { get; set; }
    }
}
