using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class BinsSortIndex
    {
        public int SortId { get; set; }
        public string Warehouse { get; set; } = null!;
        public string Area { get; set; } = null!;
        public short Row { get; set; }
        public short Col { get; set; }
        public short SortIndex { get; set; }
        public short SortIndexA { get; set; }
    }
}
