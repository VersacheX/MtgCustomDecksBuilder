using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontNoteLog
    {
        public long Uniquefier { get; set; }
        public short StorefrontId { get; set; }
        public DateTime DateTime { get; set; }
        public short AdminId { get; set; }
        public string? Notes { get; set; }
        public DateTime? FollowupDate { get; set; }
        public short NoteTypeId { get; set; }
    }
}
