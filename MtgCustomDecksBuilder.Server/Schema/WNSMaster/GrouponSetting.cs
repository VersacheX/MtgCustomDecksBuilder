using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GrouponSetting
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string? Sftphost { get; set; }
        public string? Sftpuser { get; set; }
        public string? Sftppassword { get; set; }
        public int? DefaultShipMethodId { get; set; }
        public string? EmailDomain { get; set; }
        public string? EmailNotificationsOrderImport { get; set; }
    }
}
