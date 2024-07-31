using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GroupsDiscountsProdOverride
    {
        public int Uniquefier { get; set; }
        public int GroupId { get; set; }
        public int ProdId { get; set; }
        public decimal PercentOffStdWhls { get; set; }
        public bool IsMinimumPrice { get; set; }

        public virtual Group Group { get; set; } = null!;
        public virtual ProdsProduct Prod { get; set; } = null!;
    }
}
