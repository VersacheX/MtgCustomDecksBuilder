using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EBayLmsJob
    {
        public int Id { get; set; }
        public string? JobId { get; set; }
        public string? JobType { get; set; }
        public string? FileRefId { get; set; }
        public string? JobStatus { get; set; }
        public string? PathToFile { get; set; }
        public bool IsSandBox { get; set; }
        public string? StatusMessagesUpload { get; set; }
        public string? StatusMessagesDownload { get; set; }
        public string? StatusErrorMessagesUpload { get; set; }
        public string? StatusErrorMessagesDownload { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? AbortedOn { get; set; }
        public DateTime? CompletedOn { get; set; }
    }
}
