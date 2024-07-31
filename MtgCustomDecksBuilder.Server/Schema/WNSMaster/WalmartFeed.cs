using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WalmartFeed
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? FileName { get; set; }
        public string? FeedId { get; set; }
        public string? Status { get; set; }
        public int? ItemsReceived { get; set; }
        public int? ItemsSucceeded { get; set; }
        public int? ItemsFailed { get; set; }
        public int? ItemsProcessing { get; set; }
        public int? Limit { get; set; }
        public int? TotalCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
    }
}
