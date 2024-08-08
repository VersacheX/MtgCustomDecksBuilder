using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class MtgCardRuling
    {
        public int MtgCardRulingPk { get; set; }
        public int? MtgCardFk { get; set; }
        public DateTime? Date { get; set; }
        public string? Text { get; set; }

        public virtual MtgCard? MtgCardFkNavigation { get; set; }
    }
}
