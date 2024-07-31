using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class NackOrder
    {
        public int ProviderOrderId { get; set; }
        public int ProdId { get; set; }
        public decimal NackPrice { get; set; }
        public decimal StorefrontPrice { get; set; }
        public DateTime DateTimeRecorded { get; set; }
    }
}
