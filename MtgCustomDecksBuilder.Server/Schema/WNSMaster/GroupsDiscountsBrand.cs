using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GroupsDiscountsBrand
    {
        public int Uniquefier { get; set; }
        public int GroupId { get; set; }
        public short BrandId { get; set; }
        public decimal PercentOffStdWhls { get; set; }
        public bool IsMinimumPrice { get; set; }

        public virtual ProdsBrand Brand { get; set; } = null!;
        public virtual Group Group { get; set; } = null!;
    }
}
