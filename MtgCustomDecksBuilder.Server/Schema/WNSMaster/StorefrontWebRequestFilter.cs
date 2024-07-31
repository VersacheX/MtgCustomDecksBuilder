using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontWebRequestFilter
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string? Ipaddress { get; set; }
        public string? UserAgent { get; set; }
        public bool? DisableRequest { get; set; }
        public bool? DisableCart { get; set; }
        public bool? DisableSimilarProducts { get; set; }
        public bool? DisablePublicSiteActivity { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Notes { get; set; }
    }
}
