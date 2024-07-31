using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AdminsStorefront
    {
        public AdminsStorefront()
        {
            AdminsStorefrontsAdminPermissions = new HashSet<AdminsStorefrontsAdminPermission>();
            StorefrontProdInfoChangeLogs = new HashSet<StorefrontProdInfoChangeLog>();
        }

        public short AdminId { get; set; }
        public short StorefrontId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool? SystemAccount { get; set; }
        public bool PrimaryAccount { get; set; }
        public bool? WebServiceAccount { get; set; }

        public virtual ICollection<AdminsStorefrontsAdminPermission> AdminsStorefrontsAdminPermissions { get; set; }
        public virtual ICollection<StorefrontProdInfoChangeLog> StorefrontProdInfoChangeLogs { get; set; }
    }
}
