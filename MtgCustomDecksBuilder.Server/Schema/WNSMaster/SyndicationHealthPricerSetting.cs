using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationHealthPricerSetting
    {
        public short StorefrontId { get; set; }
        public string? LocalDir { get; set; }
        public string? LocalFileName { get; set; }
    }
}
