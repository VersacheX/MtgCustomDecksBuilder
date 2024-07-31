using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AmazonFbaInboundShipmentPlanItem
    {
        public int Id { get; set; }
        public int InboundShipmentPlanId { get; set; }
        public int ProdId { get; set; }
        public string? SellerSku { get; set; }
        public string? Fnsku { get; set; }
        public int? Quantity { get; set; }

        public virtual AmazonFbaInboundShipmentPlan InboundShipmentPlan { get; set; } = null!;
    }
}
