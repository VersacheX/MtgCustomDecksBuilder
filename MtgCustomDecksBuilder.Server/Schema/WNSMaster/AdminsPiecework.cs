using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AdminsPiecework
    {
        public AdminsPiecework()
        {
            AdminsTimeClocks = new HashSet<AdminsTimeClock>();
        }

        public byte PieceworkId { get; set; }
        public string? Piecework { get; set; }
        public bool? ChgByPiece { get; set; }
        public byte? SortIndex { get; set; }

        public virtual ICollection<AdminsTimeClock> AdminsTimeClocks { get; set; }
    }
}
