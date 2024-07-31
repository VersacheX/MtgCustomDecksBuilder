using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Translation
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public byte LangId { get; set; }
        public string Token { get; set; } = null!;
        public string? Value { get; set; }
    }
}
