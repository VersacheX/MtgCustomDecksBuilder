using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderSampleLineItem
    {
        public int RowId { get; set; }
        public int ProviderOrderId { get; set; }
        public int SampleId { get; set; }
        public short? IncludedInOrder { get; set; }
    }
}
