using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MarketingEmailsIterableStaging
    {
        public int ProspectId { get; set; }
        public short StorefrontId { get; set; }
        public string Email { get; set; } = null!;
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public DateTime? LastMailedOn { get; set; }
        public DateTime? LastOrderedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ProcessingOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public string? ProspectIdstring { get; set; }
    }
}
