using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontNoteLogNoteType
    {
        public short NoteTypeId { get; set; }
        public string NoteAbbrev { get; set; } = null!;
        public string NoteDescription { get; set; } = null!;
    }
}
