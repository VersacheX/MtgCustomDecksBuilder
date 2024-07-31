using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsDtsPackageOlap
    {
        public int ExecId { get; set; }
        public DateTime? EmailDateSentBefore { get; set; }
        public DateTime? HitDateBefore { get; set; }
        public DateTime? EmailDateSentAfter { get; set; }
        public DateTime? HitDateAfter { get; set; }
        public string? RetValExec { get; set; }
        public DateTime? ExecDateTime { get; set; }
        public string? EmailIdbefore { get; set; }
        public string? EmailIdafter { get; set; }
        public int? UniqueIdbefore { get; set; }
        public int? UniqueIdafter { get; set; }
        public int? ReportId { get; set; }
    }
}
