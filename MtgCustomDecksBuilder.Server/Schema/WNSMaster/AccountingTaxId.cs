using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AccountingTaxId
    {
        public int TaxId { get; set; }
        public string? TaxDescObsolete { get; set; }
        public string? StateCode { get; set; }
        public string? County { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? CountryCode { get; set; }
    }
}
