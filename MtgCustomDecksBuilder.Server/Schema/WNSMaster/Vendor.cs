using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Vendor
    {
        public Vendor()
        {
            ProdsPrimaryVendors = new HashSet<ProdsPrimaryVendor>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public short VendorId { get; set; }
        public short ProviderId { get; set; }
        public string Name { get; set; } = null!;
        public string Abbrev { get; set; } = null!;
        public string? AccountNum { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Phone2 { get; set; }
        public string? Fax { get; set; }
        public string? ContactName { get; set; }
        public string? Email { get; set; }
        public string? Terms { get; set; }
        public bool? ShowPriceOnPo { get; set; }
        public bool? ShowVendorCodeOnPo { get; set; }
        public bool? IsRequireCaseQuantity { get; set; }
        public bool? IsSpecialCasePo { get; set; }
        public int? MinimumTypeId { get; set; }
        public decimal? MinimumValue { get; set; }
        public bool? SendPosun { get; set; }
        public bool? SendPomon { get; set; }
        public bool? SendPotue { get; set; }
        public bool? SendPowed { get; set; }
        public bool? SendPothu { get; set; }
        public bool? SendPofri { get; set; }
        public bool? SendPosat { get; set; }
        public int? EstimatedTransitDays { get; set; }

        public virtual ICollection<ProdsPrimaryVendor> ProdsPrimaryVendors { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
