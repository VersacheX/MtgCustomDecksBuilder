using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsFamily
    {
        public ProdsFamily()
        {
            MetatagsFams = new HashSet<MetatagsFam>();
            ProdsProducts = new HashSet<ProdsProduct>();
            Depts = new HashSet<DeptsDepartment>();
            Keywords = new HashSet<KeywordsStandard>();
        }

        public int FamId { get; set; }
        public short BrandId { get; set; }
        public short? StorefrontId { get; set; }
        public string? PicFileName { get; set; }
        public bool TaxableCa { get; set; }
        public bool TaxableNc { get; set; }
        public short? OwnedByStorefrontId { get; set; }

        public virtual ProdsBrand Brand { get; set; } = null!;
        public virtual StorefrontInfo? OwnedByStorefront { get; set; }
        public virtual ICollection<MetatagsFam> MetatagsFams { get; set; }
        public virtual ICollection<ProdsProduct> ProdsProducts { get; set; }

        public virtual ICollection<DeptsDepartment> Depts { get; set; }
        public virtual ICollection<KeywordsStandard> Keywords { get; set; }
    }
}
