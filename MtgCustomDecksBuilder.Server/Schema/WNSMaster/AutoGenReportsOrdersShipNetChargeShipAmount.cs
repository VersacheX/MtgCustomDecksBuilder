using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsOrdersShipNetChargeShipAmount
    {
        public int? OrderId { get; set; }
        public string? ServiceDesc { get; set; }
        public decimal? NetChargePlusSurcharge { get; set; }
        public decimal? ShipAmount { get; set; }
        public int? ReportId { get; set; }
    }
}
