using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationGoogleDisapproval
    {
        public int? ProdId { get; set; }
        public string? Country { get; set; }
        public string? Language { get; set; }
        public string? ItemTitle { get; set; }
        public string? IssueTitle { get; set; }
        public string? ValueInFeed { get; set; }
        public string? ValueOnWebsite { get; set; }
        public string? SamplingTime { get; set; }
        public string? DisapprovalTime { get; set; }
        public string? Channel { get; set; }
        public string? Source { get; set; }
        public string? AdditionalInformation { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
