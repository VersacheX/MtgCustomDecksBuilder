using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UserAccountsNote
    {
        public int AccountId { get; set; }
        public byte NoteTypeId { get; set; }
        public string? Notes { get; set; }
        public DateTime? LastModified { get; set; }

        public virtual UserAccount Account { get; set; } = null!;
    }
}
