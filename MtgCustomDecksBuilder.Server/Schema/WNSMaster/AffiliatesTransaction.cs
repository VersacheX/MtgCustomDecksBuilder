using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AffiliatesTransaction
    {
        public int TransactionId { get; set; }
        public byte StatusId { get; set; }
        public byte ActionId { get; set; }
        public string CampaignCode { get; set; } = null!;
        public int OrderId { get; set; }
        public int ProdId { get; set; }
        public short Qty { get; set; }
        public decimal Price { get; set; }
        public decimal CommissionAmount { get; set; }
        public int? PaymentId { get; set; }
        public string? Notes { get; set; }
        public DateTime DateTimeEntered { get; set; }
        public DateTime DateLastModified { get; set; }
        public DateTime? DateStamp { get; set; }

        public virtual AffiliatesCampaign CampaignCodeNavigation { get; set; } = null!;
    }
}
