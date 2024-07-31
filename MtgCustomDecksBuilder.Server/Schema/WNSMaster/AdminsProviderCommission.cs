using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AdminsProviderCommission
    {
        public int Uniquefier { get; set; }
        public short RelationshipId { get; set; }
        public short EndOfTheLineAdminId { get; set; }
        public short AdminIdgettingCommission { get; set; }
        public decimal CommissionPercent { get; set; }
    }
}
