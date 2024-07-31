using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MarketingPreference
    {
        public MarketingPreference()
        {
            MarketingEmailsSerials = new HashSet<MarketingEmailsSerial>();
        }

        public int ProspectId { get; set; }
        public short StorefrontId { get; set; }
        public string? Email { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public int? AccountId { get; set; }
        public byte? SalesMailingsMonthlyfrequency { get; set; }
        public byte? RefillRemindersWeeksbeforeempty { get; set; }
        public DateTime? SalesMailingsLastmailing { get; set; }
        public DateTime? RefillRemindersLastmailing { get; set; }
        public byte NumberOfBounces { get; set; }
        public DateTime? LastBounceTimeStamp { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public int? Source { get; set; }

        public virtual UserAccount? Account { get; set; }
        public virtual StorefrontInfo Storefront { get; set; } = null!;
        public virtual ICollection<MarketingEmailsSerial> MarketingEmailsSerials { get; set; }
    }
}
