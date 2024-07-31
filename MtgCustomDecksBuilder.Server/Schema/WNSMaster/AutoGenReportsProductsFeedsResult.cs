using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsProductsFeedsResult
    {
        public string? UserName { get; set; }
        public string? ProcessDescription { get; set; }
        public string? ProcessDetails { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? DateAndTime { get; set; }
        public int? ReportId { get; set; }
    }
}
