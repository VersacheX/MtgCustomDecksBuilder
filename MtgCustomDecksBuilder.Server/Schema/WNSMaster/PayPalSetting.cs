using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PayPalSetting
    {
        public short StorefrontId { get; set; }
        public string? AccessToken { get; set; }
        public string? MerchantName { get; set; }
        public string? ReportsSftphostName { get; set; }
        public string? ReportsSftpuser { get; set; }
        public string? ReportsSftppassword { get; set; }
    }
}
