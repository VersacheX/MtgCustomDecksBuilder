using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ReturnOrderActionsLog
    {
        public int Id { get; set; }
        public int Ronum { get; set; }
        public short AdminId { get; set; }
        public short ActionId { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
