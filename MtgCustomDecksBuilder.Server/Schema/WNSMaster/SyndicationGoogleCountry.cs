using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationGoogleCountry
    {
        public SyndicationGoogleCountry()
        {
            SyndicationGoogleProds = new HashSet<SyndicationGoogleProd>();
        }

        public short CountryId { get; set; }
        public string Country { get; set; } = null!;
        public string? Culture { get; set; }
        public string? CurrencyCode { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<SyndicationGoogleProd> SyndicationGoogleProds { get; set; }
    }
}
