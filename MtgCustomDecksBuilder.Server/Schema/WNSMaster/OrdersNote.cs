using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersNote
    {
        public int NoteId { get; set; }
        public short NoteTypeId { get; set; }
        public int ProviderOrderId { get; set; }
        public string? Username { get; set; }
        public DateTime NoteTimeStamp { get; set; }
        public string? Body { get; set; }

        public virtual OrdersNotesType NoteType { get; set; } = null!;
    }
}
