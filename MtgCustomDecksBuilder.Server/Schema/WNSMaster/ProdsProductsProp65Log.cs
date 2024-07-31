using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsProp65Log
    {
        public int Id { get; set; }
        public int ProdId { get; set; }
        public short AdminId { get; set; }
        public int LogStatusId { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ProdsProductsProp65LogStatus LogStatus { get; set; } = null!;
        public virtual ProdsProduct Prod { get; set; } = null!;
    }
}
