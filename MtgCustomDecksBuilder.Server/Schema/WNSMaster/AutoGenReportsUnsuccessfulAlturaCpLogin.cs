using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsUnsuccessfulAlturaCpLogin
    {
        public string ProcessDescription { get; set; } = null!;
        public int? Sfid { get; set; }
        public string? User { get; set; }
        public string? Pass { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime? DateAndTime { get; set; }
        public int? ReportId { get; set; }
    }
}
