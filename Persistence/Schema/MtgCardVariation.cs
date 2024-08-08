using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class MtgCardVariation
    {
        public int MtgCardVariationPk { get; set; }
        public int? MtgCardFk { get; set; }
        public string? VariationId { get; set; }

        public virtual MtgCard? MtgCardFkNavigation { get; set; }
    }
}
