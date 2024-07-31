using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EmailSendingAccount
    {
        public int EmailAccountId { get; set; }
        public short? ProviderId { get; set; }
        public short StorefrontId { get; set; }
        public string MailServerAddress { get; set; } = null!;
        public string MailFromAddress { get; set; } = null!;
    }
}
