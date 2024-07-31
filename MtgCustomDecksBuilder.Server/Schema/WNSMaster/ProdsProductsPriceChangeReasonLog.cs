using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsPriceChangeReasonLog
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public short AdminId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Reason { get; set; } = null!;
        public int Velocity30DaysCa { get; set; }
        public int Velocity30DaysNc { get; set; }
        public DateTime? PriceRolledBackOn { get; set; }
        public DateTime? UnusualVelocityClearedOn { get; set; }
        public string? Notes { get; set; }
    }
}
