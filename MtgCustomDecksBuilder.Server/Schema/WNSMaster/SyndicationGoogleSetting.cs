using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationGoogleSetting
    {
        public short StorefrontId { get; set; }
        public string? FtphostName { get; set; }
        public string? FtpuserName { get; set; }
        public string? Ftppassword { get; set; }
        public string? LocalDir { get; set; }
        public string? LocalFileName { get; set; }
        public string? LocalZipFileName { get; set; }
        public string? ChannelTitle { get; set; }
        public string? ChannelLink { get; set; }
        public string? ChannelDescription { get; set; }
        public string? ShippedOrdersLocalFileName { get; set; }
        public int? ShippedLastOrderIdprocessed { get; set; }
        public string? CancelledOrdersLocalFileName { get; set; }
        public int? CancelledLastOrderIdprocessed { get; set; }
        public string? SftpserverName { get; set; }
        public string? SftpserverPort { get; set; }
        public string? SftpserverFingerprint { get; set; }
        public string? Sftpusername { get; set; }
        public string? Sftppassword { get; set; }
    }
}
