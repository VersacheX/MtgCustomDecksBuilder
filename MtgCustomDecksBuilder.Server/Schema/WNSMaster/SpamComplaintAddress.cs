using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SpamComplaintAddress
    {
        public string Email { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? EmailCode { get; set; }
    }
}
