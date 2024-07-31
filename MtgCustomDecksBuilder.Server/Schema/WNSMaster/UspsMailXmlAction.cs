using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UspsMailXmlAction
    {
        public int Id { get; set; }
        public int ParentActionId { get; set; }
        public string ActionGroupName { get; set; } = null!;
        public string MessageName { get; set; } = null!;
        public string? MessageParameters { get; set; }
        public string? MessageTrackingId { get; set; }
        public string? Response { get; set; }
        public string? OnCompletedTriggerMessage { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ProcessingOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? ErredOn { get; set; }
        public int ErrorCount { get; set; }
        public string? ErrorMsg { get; set; }
        public string? RequestXml { get; set; }
    }
}
