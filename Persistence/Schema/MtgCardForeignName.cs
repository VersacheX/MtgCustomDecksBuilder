using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class MtgCardForeignName
    {
        public int MtgCardForeignNamePk { get; set; }
        public int? MtgCardFk { get; set; }
        public string? Language { get; set; }
        public int? MultiverseId { get; set; }
        public string? Name { get; set; }

        public virtual MtgCard? MtgCardFkNavigation { get; set; }
    }
}
