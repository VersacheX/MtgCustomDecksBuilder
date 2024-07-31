using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class HeartbeatUrl
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Disable { get; set; }
        public int Interval { get; set; }
        public DateTime? LastHit { get; set; }
    }
}
