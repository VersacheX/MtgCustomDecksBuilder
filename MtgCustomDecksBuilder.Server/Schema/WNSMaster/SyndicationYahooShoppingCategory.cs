using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationYahooShoppingCategory
    {
        public short CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public int? SortIndex { get; set; }
    }
}
