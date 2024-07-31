using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ReturnOrdersLineItem
    {
        public int Ronum { get; set; }
        public int ProdId { get; set; }
        public short QtyReturned { get; set; }
        public decimal Cost { get; set; }

        public virtual ReturnOrder RonumNavigation { get; set; } = null!;
    }
}
