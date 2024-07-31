using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ReturnOrderAction
    {
        public short Id { get; set; }
        public string Action { get; set; } = null!;
    }
}
