using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DeptsDepartment
    {
        public DeptsDepartment()
        {
            DeptsSpellingVariations = new HashSet<DeptsSpellingVariation>();
            MetatagsDepts = new HashSet<MetatagsDept>();
            Depts = new HashSet<DeptsDepartment>();
            Fams = new HashSet<ProdsFamily>();
            SubDeptOfs = new HashSet<DeptsDepartment>();
        }

        public short DeptId { get; set; }
        public string DeptName { get; set; } = null!;
        public DateTime? LastInfoChangeTimestamp { get; set; }

        public virtual ICollection<DeptsSpellingVariation> DeptsSpellingVariations { get; set; }
        public virtual ICollection<MetatagsDept> MetatagsDepts { get; set; }

        public virtual ICollection<DeptsDepartment> Depts { get; set; }
        public virtual ICollection<ProdsFamily> Fams { get; set; }
        public virtual ICollection<DeptsDepartment> SubDeptOfs { get; set; }
    }
}
