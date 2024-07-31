using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UserAccountsPwreset
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string? Token { get; set; }
        public string? Ipaddress { get; set; }
        public string? UserAgent { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public DateTime? CompletedOn { get; set; }
    }
}
