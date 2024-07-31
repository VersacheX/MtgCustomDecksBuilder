using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OnTracZipCodesNew
    {
        public string ZipCode { get; set; } = null!;
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Das { get; set; }
        public string? SortCode { get; set; }
        public string? Eas { get; set; }
        public int? Zone { get; set; }
        public int? TransitDays { get; set; }
    }
}
