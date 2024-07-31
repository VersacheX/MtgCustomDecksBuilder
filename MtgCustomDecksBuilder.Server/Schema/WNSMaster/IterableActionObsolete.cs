using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class IterableActionObsolete
    {
        public long Id { get; set; }
        public int TypeId { get; set; }
        public short StorefrontId { get; set; }
        public string Email { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public DateTime? ProcessingOn { get; set; }
        public DateTime? CompletedOn { get; set; }
        public DateTime? ErredOn { get; set; }
        public int ErrorCount { get; set; }
        public string? ErrorMsg { get; set; }
        public string? Parameters { get; set; }
    }
}
