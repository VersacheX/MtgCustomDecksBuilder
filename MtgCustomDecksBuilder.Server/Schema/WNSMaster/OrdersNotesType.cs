using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersNotesType
    {
        public OrdersNotesType()
        {
            OrdersNotes = new HashSet<OrdersNote>();
        }

        public short NoteTypeId { get; set; }
        public string NoteTypeDesc { get; set; } = null!;

        public virtual ICollection<OrdersNote> OrdersNotes { get; set; }
    }
}
