using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TempAccountingSalesFix20200110
    {
        public int ProviderOrderId { get; set; }
        public decimal? ShipAmountTaxable { get; set; }
    }
}
