using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class IterableSetting
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string Type { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
