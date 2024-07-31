using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GiftCertificatesRestriction
    {
        public int RestrictionId { get; set; }
        public long GiftCertificateId { get; set; }
        public int? ProdId { get; set; }
        public int? BrandId { get; set; }

        public virtual GiftCertificate GiftCertificate { get; set; } = null!;
    }
}
