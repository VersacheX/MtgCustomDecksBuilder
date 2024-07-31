using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GoogleShoppingOrder
    {
        public GoogleShoppingOrder()
        {
            GoogleShoppingOrderLines = new HashSet<GoogleShoppingOrderLine>();
        }

        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string GoogleOrderId { get; set; } = null!;
        public DateTime? PlacedDate { get; set; }
        public string? Status { get; set; }
        public string? PaymentStatus { get; set; }
        public string? TaxCollector { get; set; }
        public string? CustomerFullName { get; set; }
        public string? CustomerInvoiceReceivingEmail { get; set; }
        public string? BillingRecipientName { get; set; }
        public string? BillingStreetAddress1 { get; set; }
        public string? BillingStreetAddress2 { get; set; }
        public string? BillingStreetAddress3 { get; set; }
        public string? BillingLocality { get; set; }
        public string? BillingRegion { get; set; }
        public string? BillingPostalCode { get; set; }
        public string? BillingCountry { get; set; }
        public bool? BillingIsPostOfficeBox { get; set; }
        public string? ShippingRecipientName { get; set; }
        public string? ShippingStreetAddress1 { get; set; }
        public string? ShippingStreetAddress2 { get; set; }
        public string? ShippingStreetAddress3 { get; set; }
        public string? ShippingLocality { get; set; }
        public string? ShippingRegion { get; set; }
        public string? ShippingPostalCode { get; set; }
        public string? ShippingCountry { get; set; }
        public string? ShippingPhoneNumber { get; set; }
        public bool? ShippingIsPostOfficeBox { get; set; }
        public decimal? NetPriceAmount { get; set; }
        public decimal? NetTaxAmount { get; set; }
        public decimal? ShippingCost { get; set; }
        public decimal? ShippingCostTax { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? AcceptedOn { get; set; }
        public DateTime? RejectedOn { get; set; }
        public string? RejectedReason { get; set; }
        public DateTime? CompletedOn { get; set; }

        public virtual ICollection<GoogleShoppingOrderLine> GoogleShoppingOrderLines { get; set; }
    }
}
