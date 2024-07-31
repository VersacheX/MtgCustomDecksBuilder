using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersReturnRequestLine
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProdId { get; set; }
        public int Qty { get; set; }

        public virtual OrdersReturnRequest Request { get; set; } = null!;
    }
}
