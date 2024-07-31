using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class InterProviderBillingTransaction
    {
        public int TransNum { get; set; }
        public DateTime TransTime { get; set; }
        public byte TransClassId { get; set; }
        public string TransDesc { get; set; } = null!;
        public decimal UnitCost { get; set; }
        public int UnitQty { get; set; }
        public short FromProviderId { get; set; }
        public short ToProviderId { get; set; }
        public int? InvoiceIdassignedTo { get; set; }
        public int? ProviderOrderId { get; set; }
        public int? ProdId { get; set; }
        public decimal? CalculatedCostToProviderUpdatable { get; set; }
        public byte? CalculatedCostMethodId { get; set; }
        public DateTime? DateCostToProviderCalculated { get; set; }

        public virtual Provider FromProvider { get; set; } = null!;
        public virtual Provider ToProvider { get; set; } = null!;
        public virtual InterProviderBillingClass TransClass { get; set; } = null!;
    }
}
