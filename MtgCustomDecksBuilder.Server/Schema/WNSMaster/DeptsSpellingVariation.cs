using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DeptsSpellingVariation
    {
        public short DeptId { get; set; }
        public string StringVariation { get; set; } = null!;

        public virtual DeptsDepartment Dept { get; set; } = null!;
    }
}
