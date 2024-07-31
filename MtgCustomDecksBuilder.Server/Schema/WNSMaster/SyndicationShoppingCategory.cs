using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationShoppingCategory
    {
        public short CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public short? SortIndex { get; set; }
    }
}
