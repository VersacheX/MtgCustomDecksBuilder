using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersAction
    {
        public short ActionId { get; set; }
        public string ActionDesc { get; set; } = null!;
    }
}
