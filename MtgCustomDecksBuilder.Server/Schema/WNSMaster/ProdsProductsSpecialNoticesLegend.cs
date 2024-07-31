using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsSpecialNoticesLegend
    {
        public short NoticeId { get; set; }
        public string NoticeDesc { get; set; } = null!;
        public string? NoticeMessage { get; set; }
    }
}
