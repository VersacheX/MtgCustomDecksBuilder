using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AdminsPieceworkLog
    {
        public int Id { get; set; }
        public short AdminId { get; set; }
        public byte PieceworkId { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
    }
}
