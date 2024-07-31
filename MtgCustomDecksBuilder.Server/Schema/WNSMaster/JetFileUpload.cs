using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetFileUpload
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string FileType { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public DateTime? ReceivedOn { get; set; }
        public DateTime? ProcessingStartedOn { get; set; }
        public DateTime? ProcessingEndedOn { get; set; }
        public string? Status { get; set; }
        public int? ErrorCount { get; set; }
        public string? ErrorUrl { get; set; }
        public string? ErrorExcerpt { get; set; }
        public string? FileId { get; set; }
        public string? FileTypeTriggerOnCompletion { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
