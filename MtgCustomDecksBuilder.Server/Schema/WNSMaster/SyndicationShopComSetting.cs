using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationShopComSetting
    {
        public short StorefrontId { get; set; }
        public string? FtphostName { get; set; }
        public string? FtpuserName { get; set; }
        public string? Ftppassword { get; set; }
        public string? LocalDir { get; set; }
        public string? LocalFileName { get; set; }
        public string? LocalZipFileName { get; set; }
    }
}
