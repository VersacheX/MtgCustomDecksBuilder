using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsBrand
    {
        public ProdsBrand()
        {
            GroupsDiscountsBrands = new HashSet<GroupsDiscountsBrand>();
            MetatagsBrands = new HashSet<MetatagsBrand>();
            ProdsBrandsSpellingVariations = new HashSet<ProdsBrandsSpellingVariation>();
            ProdsFamilies = new HashSet<ProdsFamily>();
            PurchasePricingBrandNotes = new HashSet<PurchasePricingBrandNote>();
        }

        public short BrandId { get; set; }
        public int? BrandId2 { get; set; }
        public string BrandName { get; set; } = null!;
        public string? BrandName2 { get; set; }
        public string BrandAbbrev { get; set; } = null!;
        public byte Provider1AuthDistributor { get; set; }
        public byte Provider2AuthDistributor { get; set; }
        public string BrandLogoUrl { get; set; } = null!;
        public DateTime? LastInfoChangeTimestamp { get; set; }
        public bool? SuppressProp65Check { get; set; }

        public virtual ICollection<GroupsDiscountsBrand> GroupsDiscountsBrands { get; set; }
        public virtual ICollection<MetatagsBrand> MetatagsBrands { get; set; }
        public virtual ICollection<ProdsBrandsSpellingVariation> ProdsBrandsSpellingVariations { get; set; }
        public virtual ICollection<ProdsFamily> ProdsFamilies { get; set; }
        public virtual ICollection<PurchasePricingBrandNote> PurchasePricingBrandNotes { get; set; }
    }
}
