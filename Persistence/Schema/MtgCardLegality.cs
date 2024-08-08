using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class MtgCardLegality
    {
        public int MtgCardLegalityPk { get; set; }
        public int? MtgCardFk { get; set; }
        public string? Format { get; set; }
        public string? Legality { get; set; }

        public virtual MtgCard? MtgCardFkNavigation { get; set; }
    }
}
