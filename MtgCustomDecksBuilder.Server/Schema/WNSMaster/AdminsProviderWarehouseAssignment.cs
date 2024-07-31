using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AdminsProviderWarehouseAssignment
    {
        public short AdminId { get; set; }
        public short WarehouseId { get; set; }

        public virtual AdminsProvider Admin { get; set; } = null!;
    }
}
