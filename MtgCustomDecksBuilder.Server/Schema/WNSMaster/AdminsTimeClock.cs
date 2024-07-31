using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AdminsTimeClock
    {
        public int Id { get; set; }
        public short AdminId { get; set; }
        public byte? PieceworkId { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public string? PieceworkDesc { get; set; }

        public virtual AdminsProvider Admin { get; set; } = null!;
        public virtual AdminsPiecework? Piecework { get; set; }
    }
}
