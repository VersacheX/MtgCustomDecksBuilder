using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderKountRisresult
    {
        public int RecordId { get; set; }
        public int ProviderOrderId { get; set; }
        public string? Version { get; set; }
        public string? Mode { get; set; }
        public string? TransactionId { get; set; }
        public int? MerchantId { get; set; }
        public string? SessionId { get; set; }
        public string? OrderNumber { get; set; }
        public string? Auto { get; set; }
        public int? Score { get; set; }
        public string? Geox { get; set; }
        public string? Brand { get; set; }
        public string? Region { get; set; }
        public string? Network { get; set; }
        public string? Kaptcha { get; set; }
        public int? Cards { get; set; }
        public int? Devices { get; set; }
        public int? Emails { get; set; }
        public int? Velo { get; set; }
        public int? Vmax { get; set; }
        public string? Site { get; set; }
        public string? Devicelayers { get; set; }
        public string? Fingerprint { get; set; }
        public string? Timezone { get; set; }
        public string? LocalTime { get; set; }
        public string? ReasonCode { get; set; }
        public string? MobileForwarder { get; set; }
        public string? MobileType { get; set; }
        public string? MobileDevice { get; set; }
        public string? MasterCardFraudScore { get; set; }
        public string? Pcremote { get; set; }
        public string? VoiceDevice { get; set; }
        public string? Os { get; set; }
        public string? Browser { get; set; }
        public string? DeviceScreenResolution { get; set; }
        public string? UserAgentString { get; set; }
        public string? Language { get; set; }
        public string? KnowYourCustomer { get; set; }
        public string? DateDeviceFirstSeen { get; set; }
        public string? Country { get; set; }
        public string? Proxy { get; set; }
        public string? Javascript { get; set; }
        public string? Flash { get; set; }
        public string? Cookies { get; set; }
        public string? HttpCountry { get; set; }
        public string? Ipaddress { get; set; }
        public decimal? Iplatitude { get; set; }
        public decimal? Iplongitude { get; set; }
        public string? Ipcountry { get; set; }
        public string? Ipregion { get; set; }
        public string? Ipcity { get; set; }
        public string? Iporganization { get; set; }
        public string? Pipaddress { get; set; }
        public decimal? Piplatitude { get; set; }
        public decimal? Piplongitude { get; set; }
        public string? Pipcountry { get; set; }
        public string? Pipregion { get; set; }
        public string? Pipcity { get; set; }
        public string? Piporganization { get; set; }
        public DateTime DateTimeInserted { get; set; }

        public virtual OrdersProvider ProviderOrder { get; set; } = null!;
    }
}
