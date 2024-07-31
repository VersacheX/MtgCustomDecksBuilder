using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WarehouseGsoShippingSetting
    {
        public short WrhsId { get; set; }
        public byte SettingId { get; set; }
        public bool IsDefault { get; set; }

        public virtual GsoShippingSetting Setting { get; set; } = null!;
    }
}
