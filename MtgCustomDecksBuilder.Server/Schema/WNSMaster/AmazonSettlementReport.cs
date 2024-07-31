using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AmazonSettlementReport
    {
        public int RecordId { get; set; }
        public string SettlementId { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DepositDate { get; set; }
        public string TransactionType { get; set; } = null!;
        public DateTime PostedDate { get; set; }
        public string OrderId { get; set; } = null!;
        public string OrderItemId { get; set; } = null!;
        public string Sku { get; set; } = null!;
        public short? QtyPurchased { get; set; }
        public decimal? ItemPriceCredit { get; set; }
        public decimal? ItemTaxCredit { get; set; }
        public decimal? ShippingPriceCredit { get; set; }
        public decimal? ShippingTaxCredit { get; set; }
        public decimal? OrderRelatedFees { get; set; }
        public decimal? OtherFees { get; set; }
        public decimal? GoodwillCredit { get; set; }
        public string? MarketplaceName { get; set; }
        public string? Currency { get; set; }
        public decimal? ExchangeRate { get; set; }
    }
}
