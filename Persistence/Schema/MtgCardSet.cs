using System;
using System.Collections.Generic;

namespace Persistence.Schema
{
    public partial class MtgCardSet
    {
        public int MtgCardSetPk { get; set; }
        public int? MtgCardFk { get; set; }
        public int? MtgSetFk { get; set; }

        public virtual MtgCard? MtgCardFkNavigation { get; set; }
        public virtual MtgSet? MtgSetFkNavigation { get; set; }
    }
}
