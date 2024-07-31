using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AdminsStorefrontsAdminPermission
    {
        public short AdminPermId { get; set; }
        public short AdminId { get; set; }
        public short PermissionId { get; set; }
        public bool? IsActive { get; set; }

        public virtual AdminsStorefront Admin { get; set; } = null!;
        public virtual AdminsStorefrontsPermission Permission { get; set; } = null!;
    }
}
