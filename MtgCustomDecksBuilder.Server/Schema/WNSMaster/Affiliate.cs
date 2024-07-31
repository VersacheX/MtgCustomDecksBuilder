using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Affiliate
    {
        public Affiliate()
        {
            AffiliatesCampaigns = new HashSet<AffiliatesCampaign>();
            AffiliatesCommissionOverrides = new HashSet<AffiliatesCommissionOverride>();
            AffiliatesPayments = new HashSet<AffiliatesPayment>();
        }

        public int AffiliateId { get; set; }
        public short StorefrontId { get; set; }
        public short StatusId { get; set; }
        public string? SiteName { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string? ContactLastName { get; set; }
        public string ContactAddress { get; set; } = null!;
        public string? ContactAddress2 { get; set; }
        public string ContactCity { get; set; } = null!;
        public string ContactState { get; set; } = null!;
        public string ContactZip { get; set; } = null!;
        public string ContactCountry { get; set; } = null!;
        public string? ContactPhone { get; set; }
        public string ContactEmail { get; set; } = null!;
        public string? PayableTo { get; set; }
        public string? TaxType { get; set; }
        public string? TaxReferenceType { get; set; }
        public string? TaxReference { get; set; }
        public string? Url { get; set; }
        public decimal? DefaultCommissionPercent { get; set; }
        public short? DefaultReturnDays { get; set; }
        public string? Notes { get; set; }
        public bool IsTrainer { get; set; }
        public bool EmailRecommendedCartEnabled { get; set; }
        public string? TrainerFirstName { get; set; }
        public string? TrainerLastName { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateLastModified { get; set; }
        public string? AvgClients { get; set; }

        public virtual AffiliatesStatus Status { get; set; } = null!;
        public virtual ICollection<AffiliatesCampaign> AffiliatesCampaigns { get; set; }
        public virtual ICollection<AffiliatesCommissionOverride> AffiliatesCommissionOverrides { get; set; }
        public virtual ICollection<AffiliatesPayment> AffiliatesPayments { get; set; }
    }
}
