using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderPrintedOutputType
    {
        public byte TypeId { get; set; }
        public string TypeName { get; set; } = null!;
    }
}
