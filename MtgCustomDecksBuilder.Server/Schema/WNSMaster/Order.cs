using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Order
    {
        public Order()
        {
            OrdersLineItems = new HashSet<OrdersLineItem>();
        }

        public int ProviderOrderId { get; set; }
        public short StorefrontId { get; set; }
        public DateTime DateTimeImported { get; set; }
        public DateTime DateTimeOrderPlaced { get; set; }
        public DateTime? ReadyForReview { get; set; }
        public DateTime? ReadyToProcess { get; set; }
        public DateTime? InProcess { get; set; }
        public DateTime? Void { get; set; }
        public DateTime? ReadyForPickup { get; set; }
        public DateTime? InProcessInvalidShipAddress { get; set; }
        public DateTime? InProcessProdNotAvail { get; set; }
        public DateTime? InProcessProdRemovalRequired { get; set; }
        public bool? FraudWarningFlag { get; set; }
        public int? ConsumerAccountId { get; set; }
        public byte? SourceId { get; set; }
        public short? StorefrontAdminId { get; set; }
        public string? StorefrontCartId { get; set; }
        public string? StorefrontSessionId { get; set; }
        public string StorefrontOrderId { get; set; } = null!;
        public string? ClientIpaddress { get; set; }
        public string BillToFname { get; set; } = null!;
        public string? BillToMname { get; set; }
        public string BillToLname { get; set; } = null!;
        public string BillToAddress { get; set; } = null!;
        public string? BillToAddress2 { get; set; }
        public string BillToCity { get; set; } = null!;
        public string BillToState { get; set; } = null!;
        public string BillToZip { get; set; } = null!;
        public string BillToCountry { get; set; } = null!;
        public string? BillToPhone { get; set; }
        public string? BillToEmail { get; set; }
        public string ShipToFname { get; set; } = null!;
        public string? ShipToMname { get; set; }
        public string ShipToLname { get; set; } = null!;
        public string ShipToAddress { get; set; } = null!;
        public string? ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; } = null!;
        public string ShipToState { get; set; } = null!;
        public string ShipToZip { get; set; } = null!;
        public short ShipToCountryId { get; set; }
        public string? ShipToPhone { get; set; }
        public string? ShipToEmail { get; set; }
        public byte? ShipAddressVerified { get; set; }
        public decimal ShipAmount { get; set; }
        public byte ProcessingType { get; set; }
        public byte? PrintedOutputType { get; set; }
        public int ShipMethodIddesired { get; set; }
        public string? ShipMethodDescDesired { get; set; }
        public string? SalesTaxDesc { get; set; }
        public decimal SalesTaxPercent { get; set; }
        public decimal? SalesTaxAmount { get; set; }
        public byte? InsTypeIddesired { get; set; }
        public decimal InsAmount { get; set; }
        public string? InsDesc { get; set; }
        public bool? InsuranceRequired { get; set; }
        public string? CouponCode { get; set; }
        public string? CouponDesc { get; set; }
        public decimal CouponAppliedAmount { get; set; }
        public string? CommentsFromConsumer { get; set; }
        public decimal StorefrontPriceTot { get; set; }
        public decimal? PubPriceTot { get; set; }
        public decimal? RetailPriceTot { get; set; }
        public decimal OrderGrandTotal { get; set; }
        public string PaymentMethod { get; set; } = null!;
        public string? CctypeCode { get; set; }
        public string? NameAsOnCc { get; set; }
        public string? CcexpMonth { get; set; }
        public string? CcexpYear { get; set; }
        public string? CheckAccountNum { get; set; }
        public string? CheckRoutingNum { get; set; }
        public byte? CheckAccountType { get; set; }
        public DateTime? DateFollowUp { get; set; }
        public string? StoreName { get; set; }
        public string? StoreAddress { get; set; }
        public string? StoreAddress2 { get; set; }
        public string? StoreCity { get; set; }
        public string? StoreState { get; set; }
        public string? StoreZip { get; set; }
        public string? StorePhone { get; set; }
        public string? StoreFax { get; set; }
        public string? StoreEmail { get; set; }
        public string? StoreMemo { get; set; }
        public string? StoreFooter { get; set; }
        public short? SuggestedCarrierId { get; set; }
        public int? TempTestMirrorOrderId { get; set; }
        public string? TempTestBf { get; set; }
        public string? TempTestBm { get; set; }
        public string? TempTestBl { get; set; }
        public string? TempTestBa { get; set; }
        public string? TempTestBa2 { get; set; }
        public string? TempTestBc { get; set; }
        public string? TempTestBs { get; set; }
        public string? TempTestBz { get; set; }
        public string? TempTestBp { get; set; }
        public string? TempTestBe { get; set; }
        public string? TempTestSf { get; set; }
        public string? TempTestSm { get; set; }
        public string? TempTestSl { get; set; }
        public string? TempTestSa { get; set; }
        public string? TempTestSa2 { get; set; }
        public string? TempTestSc { get; set; }
        public string? TempTestSs { get; set; }
        public string? TempTestSz { get; set; }
        public string? TempTestSp { get; set; }
        public string? TempTestSe { get; set; }
        public string? TempTestStd { get; set; }
        public decimal? TempTestStp { get; set; }
        public decimal? TempTestSta { get; set; }
        public decimal? TempTestPpt { get; set; }
        public decimal? TempTestOgt { get; set; }

        public virtual UserAccount? ConsumerAccount { get; set; }
        public virtual ShippingMethod ShipMethodIddesiredNavigation { get; set; } = null!;
        public virtual OrdersSource? Source { get; set; }
        public virtual ICollection<OrdersLineItem> OrdersLineItems { get; set; }
    }
}
