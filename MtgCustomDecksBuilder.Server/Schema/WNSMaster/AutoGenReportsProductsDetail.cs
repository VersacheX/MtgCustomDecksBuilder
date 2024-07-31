using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsProductsDetail
    {
        public int ReportNumber { get; set; }
        public short WrhsId { get; set; }
        public int ProdId { get; set; }
        public DateTime DateTime { get; set; }
        public int? OneYearVel { get; set; }
        public int? PoUnits { get; set; }
        public decimal? PoValue { get; set; }
        public int? AvailabilityInv { get; set; }
        public int? AvailabilityShelf { get; set; }
        public int? AvailabilityAvailable { get; set; }
        public DateTime? AvailabilityExpectedDate { get; set; }
    }
}
