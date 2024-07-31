using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AdminsStorefrontsPermission
    {
        public AdminsStorefrontsPermission()
        {
            AdminsStorefrontsAdminPermissions = new HashSet<AdminsStorefrontsAdminPermission>();
        }

        public short PermissionId { get; set; }
        public string PermissionDesc { get; set; } = null!;
        public bool? PermissionIsActive { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<AdminsStorefrontsAdminPermission> AdminsStorefrontsAdminPermissions { get; set; }
    }
}
