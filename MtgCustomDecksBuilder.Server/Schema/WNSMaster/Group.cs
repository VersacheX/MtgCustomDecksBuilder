using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Group
    {
        public Group()
        {
            GroupsDiscountsBrands = new HashSet<GroupsDiscountsBrand>();
            GroupsDiscountsProdOverrides = new HashSet<GroupsDiscountsProdOverride>();
            Storefronts = new HashSet<StorefrontInfo>();
        }

        public int GroupId { get; set; }
        public short ProviderId { get; set; }
        public string GroupName { get; set; } = null!;
        public string? GroupDescription { get; set; }
        public byte UniversalTier { get; set; }
        public short? ExclusiveToAdminId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? LastRunDate { get; set; }

        public virtual ICollection<GroupsDiscountsBrand> GroupsDiscountsBrands { get; set; }
        public virtual ICollection<GroupsDiscountsProdOverride> GroupsDiscountsProdOverrides { get; set; }

        public virtual ICollection<StorefrontInfo> Storefronts { get; set; }
    }
}
