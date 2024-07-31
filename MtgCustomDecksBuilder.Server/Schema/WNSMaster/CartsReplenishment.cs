using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CartsReplenishment
    {
        public int CartId { get; set; }
        public int AdminId { get; set; }
        public string BinId { get; set; } = null!;
        public int ProdId { get; set; }
        public short Qty { get; set; }
    }
}
