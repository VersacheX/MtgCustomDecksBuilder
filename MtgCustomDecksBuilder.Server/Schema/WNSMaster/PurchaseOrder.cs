using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrdersLineItems = new HashSet<PurchaseOrdersLineItem>();
        }

        public int Ponum { get; set; }
        public short ProviderId { get; set; }
        public short WrhsId { get; set; }
        public short? VendorId { get; set; }
        public DateTime DatePlaced { get; set; }
        public string? PurchaserInfo { get; set; }
        public string? ShipToInfo { get; set; }
        public string? Vendor { get; set; }
        public string? Notes { get; set; }
        public DateTime? DateExpected { get; set; }
        public short? ReceivingSignoffBy { get; set; }
        public DateTime? ReceivingSignoffTime { get; set; }
        public short? AccountingSignoffBy { get; set; }
        public DateTime? AccountingSignoffTime { get; set; }
        public bool? ShowPriceOnPo { get; set; }
        public bool? ShowVendorCodeOnPo { get; set; }
        public string? VendorNotesObsolete { get; set; }
        public DateTime? Confirmed { get; set; }
        public string? VendorNotes { get; set; }
        public bool? IsSpecialCasePo { get; set; }
        public int? TransferOrderId { get; set; }
        public bool? IsTransferStagingPo { get; set; }
        public bool? IsTransferPo { get; set; }
        public bool? IsTransferPendingPo { get; set; }
        public string? TransferId { get; set; }
        public DateTime? StockConfirmed { get; set; }

        public virtual Vendor? VendorNavigation { get; set; }
        public virtual ICollection<PurchaseOrdersLineItem> PurchaseOrdersLineItems { get; set; }
    }
}
