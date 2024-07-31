using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ReturnOrder
    {
        public ReturnOrder()
        {
            ReturnOrdersLineItems = new HashSet<ReturnOrdersLineItem>();
        }

        public int Ronum { get; set; }
        public short ProviderId { get; set; }
        public short VendorId { get; set; }
        public string? HeaderInfo { get; set; }
        public string? CreditToInfo { get; set; }
        public string? Notes { get; set; }
        public DateTime DatePlaced { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? SignOffByPurchasing { get; set; }
        public DateTime? SignOffByAccounting { get; set; }
        public short? SignOffByPurchasingAdminId { get; set; }
        public short? SignOffByAccountingAdminId { get; set; }
        public string? Ronotes { get; set; }
        public DateTime? DateFollowUp { get; set; }
        public bool? ShowVendorSku { get; set; }

        public virtual ICollection<ReturnOrdersLineItem> ReturnOrdersLineItems { get; set; }
    }
}
