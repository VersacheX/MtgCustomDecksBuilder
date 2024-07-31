using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsOrdersChannelsCountDaily
    {
        public int? ReportId { get; set; }
        public string? Channel { get; set; }
        public int? OrderCount { get; set; }
    }
}
