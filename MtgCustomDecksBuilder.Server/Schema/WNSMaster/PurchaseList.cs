using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseList
    {
        public int ProdId { get; set; }
        public short ProviderId { get; set; }
        public string? Comments { get; set; }
    }
}
