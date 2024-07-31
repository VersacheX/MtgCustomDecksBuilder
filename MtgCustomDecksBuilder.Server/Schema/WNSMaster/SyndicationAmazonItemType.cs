using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationAmazonItemType
    {
        public short ItemTypeId { get; set; }
        public string ItemType { get; set; } = null!;
        public int? SortIndex { get; set; }
    }
}
