using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsScriptGroupsPricing
    {
        public int? GroupId { get; set; }
        public string? GroupName { get; set; }
        public string? GroupDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastRunDate { get; set; }
        public int? ExclusiveToAdminId { get; set; }
        public string? Username { get; set; }
        public int? DefaultPricingGroupId { get; set; }
        public int? ReportId { get; set; }
    }
}
