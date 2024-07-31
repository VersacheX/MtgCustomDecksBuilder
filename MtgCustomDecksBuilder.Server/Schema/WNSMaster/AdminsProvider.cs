using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AdminsProvider
    {
        public AdminsProvider()
        {
            AdminsTimeClocks = new HashSet<AdminsTimeClock>();
            InventoryAdjustments = new HashSet<InventoryAdjustment>();
            StorefrontProdInfoChangeLogs = new HashSet<StorefrontProdInfoChangeLog>();
            TransferOrderReceiveSignOffByAdmins = new HashSet<TransferOrder>();
            TransferOrderShippedByAdmins = new HashSet<TransferOrder>();
        }

        public short AdminId { get; set; }
        public short ProviderId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? PublicName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Firtext { get; set; }
        public decimal? Rate { get; set; }
        public bool AccountEnabled { get; set; }
        public bool PermSysAdmin { get; set; }
        public bool PermPickPack { get; set; }
        public bool PermCreateEditPo { get; set; }
        public bool PermViewPo { get; set; }
        public bool PermReceiveInvForPo { get; set; }
        public bool PermAdjustInventory { get; set; }
        public bool PermAddEditProdsExceptPrice { get; set; }
        public bool PermAddEditProdsIncludingPrice { get; set; }
        public bool PermViewMarketingInfo { get; set; }
        public bool PermStorefrontManagement { get; set; }
        public bool PermCreateEditWholesaleOrders { get; set; }
        public bool PermEditShipTypes { get; set; }
        public bool PermEditVendors { get; set; }
        public bool PermCreateEditRo { get; set; }
        public bool PermCreateBoxSuggestions { get; set; }
        public bool PermEditTimeSheets { get; set; }
        public bool PermProcessCustomerReturns { get; set; }
        public bool PermViewDropshipBillingInfo { get; set; }
        public bool PermCreateEditDropshipBillingInfo { get; set; }
        public bool PermCreateOrderBatches { get; set; }
        public bool PermEditWholesaleOrdersPayments { get; set; }
        public bool PermSupervisor { get; set; }
        public bool PermSalesSupervisor { get; set; }
        public bool PermCreateEditWholesaleOrdersWithSensitiveInfo { get; set; }
        public bool PermSalesRepBasic { get; set; }
        public bool PermCreateEditInterProviderBillingInfo { get; set; }

        public virtual AdminsProviderWarehouseAssignment? AdminsProviderWarehouseAssignment { get; set; }
        public virtual ICollection<AdminsTimeClock> AdminsTimeClocks { get; set; }
        public virtual ICollection<InventoryAdjustment> InventoryAdjustments { get; set; }
        public virtual ICollection<StorefrontProdInfoChangeLog> StorefrontProdInfoChangeLogs { get; set; }
        public virtual ICollection<TransferOrder> TransferOrderReceiveSignOffByAdmins { get; set; }
        public virtual ICollection<TransferOrder> TransferOrderShippedByAdmins { get; set; }
    }
}
