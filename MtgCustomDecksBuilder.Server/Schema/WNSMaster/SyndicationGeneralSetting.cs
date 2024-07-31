using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationGeneralSetting
    {
        public short StorefrontId { get; set; }
        public string HomeDir { get; set; } = null!;
        public string HomeUrl { get; set; } = null!;
    }
}
