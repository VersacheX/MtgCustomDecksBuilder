using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsPriceChangeLog
    {
        public int Id { get; set; }
        public int ProdId { get; set; }
        public short AdminId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Field { get; set; } = null!;
        public decimal OldValue { get; set; }
        public decimal NewValue { get; set; }
    }
}
