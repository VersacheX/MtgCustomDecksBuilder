using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MarketingEmailsTemplateDatum
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string Template { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? Value { get; set; }
    }
}
