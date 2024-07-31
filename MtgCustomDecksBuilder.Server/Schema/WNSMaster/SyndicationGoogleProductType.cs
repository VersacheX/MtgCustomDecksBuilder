using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationGoogleProductType
    {
        public short ProductTypeId { get; set; }
        public string ProductType { get; set; } = null!;
        public int? SortIndex { get; set; }
    }
}
