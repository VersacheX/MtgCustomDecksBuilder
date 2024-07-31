using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EmailBounceLog
    {
        public int LogId { get; set; }
        public string? BouncedEmailAddress { get; set; }
        public string? MesssageSubject { get; set; }
        public string? CustomHeaderDate { get; set; }
        public string? CustomHeaderMessageId { get; set; }
        public string? BounceCheckReturnValue { get; set; }
        public string? MessageFromAddress { get; set; }
        public string? MessageFromFriendlyName { get; set; }
        public string? MessageReplyToAddress { get; set; }
        public string? MessageReplyToFriendlyName { get; set; }
        public string? MesssageToAddress { get; set; }
        public string? MessageToFriendlyName { get; set; }
        public string? Message { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
