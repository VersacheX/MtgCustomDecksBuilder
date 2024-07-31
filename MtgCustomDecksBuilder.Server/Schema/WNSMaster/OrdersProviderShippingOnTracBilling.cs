using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingOnTracBilling
    {
        public int DetailId { get; set; }
        public int? ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? Vendor { get; set; }
        public string? InvNo { get; set; }
        public string? InvoiceDate { get; set; }
        public decimal? TotalCost { get; set; }
        public string? RemitToCity { get; set; }
        public string? Reference { get; set; }
        public string? ShipDate { get; set; }
        public decimal? TotalCharge { get; set; }
        public string? TrackingNum { get; set; }
        public string? FromCompany { get; set; }
        public string? FromName { get; set; }
        public string? FromStreet { get; set; }
        public string? FromCity { get; set; }
        public string? FromState { get; set; }
        public string? FromZip { get; set; }
        public string? FromCountry { get; set; }
        public string? ToCompany { get; set; }
        public string? ToName { get; set; }
        public string? ToStreet { get; set; }
        public string? ToCity { get; set; }
        public string? ToState { get; set; }
        public string? ToZip { get; set; }
        public string? ToCountry { get; set; }
        public string? Service { get; set; }
        public decimal? Weight { get; set; }

        public virtual OrdersProviderShippingOnTracBillingImport? Import { get; set; }
    }
}
