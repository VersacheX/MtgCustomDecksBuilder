using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationShopComAttribute
    {
        public short AttributeId { get; set; }
        public string AttributeName { get; set; } = null!;
        public short? SortIndex { get; set; }
    }
}
