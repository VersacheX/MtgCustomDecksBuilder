using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OnTracZipCodesInfo
    {
        public string ZipCode { get; set; } = null!;
        public string? SortCode { get; set; }
        public string? ServiceArea { get; set; }
        public string? Surcharge { get; set; }
        public int? Zone { get; set; }
        public int? TransitDays { get; set; }
        public string? Version { get; set; }
        public short WrhsId { get; set; }
        public DateTime? DisabledOn { get; set; }
    }
}
