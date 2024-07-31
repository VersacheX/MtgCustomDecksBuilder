using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Redirect
    {
        public int RedirectId { get; set; }
        public string FromUrl { get; set; } = null!;
        public string ToUrl { get; set; } = null!;
        public string? Notes { get; set; }
    }
}
