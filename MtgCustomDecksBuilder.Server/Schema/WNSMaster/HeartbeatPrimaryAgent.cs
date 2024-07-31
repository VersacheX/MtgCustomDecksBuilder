using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class HeartbeatPrimaryAgent
    {
        public int Id { get; set; }
        public int? AgentId { get; set; }
        public string? Status { get; set; }
    }
}
