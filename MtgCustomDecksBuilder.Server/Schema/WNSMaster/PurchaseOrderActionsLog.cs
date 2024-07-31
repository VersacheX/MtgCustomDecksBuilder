using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseOrderActionsLog
    {
        public int Id { get; set; }
        public int Ponum { get; set; }
        public short AdminId { get; set; }
        public short ActionId { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
