using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsRefillReminder
    {
        public string? UserName { get; set; }
        public string? ProcessDescription { get; set; }
        public int? Total { get; set; }
        public int? Sent { get; set; }
        public int? Errors { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? DateAndTime { get; set; }
        public int? ReportId { get; set; }
    }
}
