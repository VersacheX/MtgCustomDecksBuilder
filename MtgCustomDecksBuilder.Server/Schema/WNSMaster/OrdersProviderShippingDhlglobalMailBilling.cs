using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingDhlglobalMailBilling
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? SoldTo { get; set; }
        public int? InvPosNum { get; set; }
        public string? Bol { get; set; }
        public string? BillRef { get; set; }
        public string? BillRef2 { get; set; }
        public string? ShipPoint { get; set; }
        public string? PickupFrom { get; set; }
        public string? Pudate { get; set; }
        public string? Putime { get; set; }
        public string? InternalTrackingNum { get; set; }
        public string? CustomerConfirmation { get; set; }
        public string? DeliveryConfirmation { get; set; }
        public string? Name { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
        public string? MaterialOrVasNum { get; set; }
        public string? MaterialOrVasDesc { get; set; }
        public decimal? ActWeight { get; set; }
        public string? ActWeightUom { get; set; }
        public decimal? BillWeight { get; set; }
        public string? BillWeightUom { get; set; }
        public int? Quantity { get; set; }
        public string? QuantityUom { get; set; }
        public string? PricingZone { get; set; }
        public decimal? Charge { get; set; }
        public string? CustomerRef { get; set; }
        public decimal? ScreeningFee { get; set; }
        public decimal? Zfuel { get; set; }
        public decimal? MinPickupCharge { get; set; }

        public virtual OrdersProviderShippingDhlglobalMailBillingImport Import { get; set; } = null!;
    }
}
