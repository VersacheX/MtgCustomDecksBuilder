using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MetatagsFamsOverride
    {
        public int FamId { get; set; }
        public short StorefrontId { get; set; }
        public string? Content { get; set; }
    }
}
