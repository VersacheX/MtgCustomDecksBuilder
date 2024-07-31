using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TransferOrdersLineItem
    {
        public long Uniquefier { get; set; }
        public int Tonum { get; set; }
        public long TakenFromPoLiUniquefier { get; set; }
        public long? AddedToPoLiUniquefier { get; set; }
        public int QtyShipped { get; set; }
        public int? QtyReceived { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public short CheckedOutByAdminId { get; set; }
        public DateTime? DateCheckedIn { get; set; }
        public short? CheckedInByAdminId { get; set; }

        public virtual TransferOrder TonumNavigation { get; set; } = null!;
    }
}
