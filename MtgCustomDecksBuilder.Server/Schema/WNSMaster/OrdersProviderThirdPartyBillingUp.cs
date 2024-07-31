using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderThirdPartyBillingUp
    {
        public int ProviderOrderId { get; set; }
        public string? UpscompanyOrName { get; set; }
        public string? Upsattention { get; set; }
        public string? Upsstreet { get; set; }
        public string? UpsroomFloorAddress2 { get; set; }
        public string? UpsdepartmentAddress3 { get; set; }
        public string? Upscity { get; set; }
        public string? UpsstateProv { get; set; }
        public string? UpszipCode { get; set; }
        public string? Upscountry { get; set; }
        public string? Upstelephone { get; set; }
        public string? Upsfax { get; set; }
        public string? UpsaccountNumber { get; set; }
        public string? Upsref1 { get; set; }
        public string? Upsref2 { get; set; }
    }
}
