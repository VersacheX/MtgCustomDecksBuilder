using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderMaxMindFraudResult
    {
        public int Id { get; set; }
        public int ProviderOrderId { get; set; }
        public int Distance { get; set; }
        public string? CountryMatch { get; set; }
        public string CountryCode { get; set; } = null!;
        public string? FreeMail { get; set; }
        public string? AnonymousProxy { get; set; }
        public decimal? Score { get; set; }
        public string BinMatch { get; set; } = null!;
        public string? BinCountry { get; set; }
        public string? Error { get; set; }
        public decimal? ProxyScore { get; set; }
        public string? IpRegion { get; set; }
        public string? IpCity { get; set; }
        public string? IpLatitude { get; set; }
        public string? IpLongitude { get; set; }
        public string? BinName { get; set; }
        public string? IpIsp { get; set; }
        public string? IpOrg { get; set; }
        public string? BinNameMatch { get; set; }
        public string? BinPhoneMatch { get; set; }
        public string? BinPhone { get; set; }
        public string? CustPhoneInBillingLoc { get; set; }
        public string? HighRiskCountry { get; set; }
        public string? CityPostalMatch { get; set; }
        public string? ShipCityPostalMatch { get; set; }
        public int QueriesRemaining { get; set; }
        public decimal RiskScore { get; set; }
        public string Explanation { get; set; } = null!;
        public short? AdminId { get; set; }
    }
}
