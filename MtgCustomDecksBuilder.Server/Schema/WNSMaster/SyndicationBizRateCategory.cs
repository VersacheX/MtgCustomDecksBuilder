using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationBizRateCategory
    {
        public short CategoryId { get; set; }
        public string? CategoryCode { get; set; }
        public string CategoryName { get; set; } = null!;
        public int? SortIndex { get; set; }
    }
}
