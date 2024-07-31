using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetMerchantSkusAvailable
    {
        public int? ProdId { get; set; }
        public string? Title { get; set; }
        public string? Status { get; set; }
        public string? Substatus { get; set; }
        public string? Inventory { get; set; }
    }
}
