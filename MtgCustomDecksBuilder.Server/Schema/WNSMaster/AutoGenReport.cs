using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReport
    {
        public int ReportId { get; set; }
        public string? ReportName { get; set; }
        public string? ReportDesc { get; set; }
        public DateTime? DateTimeGenerated { get; set; }
    }
}
