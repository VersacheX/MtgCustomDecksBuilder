using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ObsoleteContent
    {
        public int RecordId { get; set; }
        public short StorefrontId { get; set; }
        public string Url { get; set; } = null!;
        public byte TypeId { get; set; }
        public int? ProdId { get; set; }
        public int? FamId { get; set; }
        public short? DeptId { get; set; }
        public short? BrandId { get; set; }
        public string? Keyword { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAndTime { get; set; }
        public bool Hide { get; set; }
    }
}
