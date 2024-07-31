using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseOrdersUnrecognizedProd
    {
        public int Ponum { get; set; }
        public string Upc { get; set; } = null!;
        public short? Qty { get; set; }
        public string? Description { get; set; }
    }
}
