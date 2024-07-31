using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UrlMapping
    {
        public int MapId { get; set; }
        public string MapFrom { get; set; } = null!;
        public string MapTo { get; set; } = null!;
        public bool Active { get; set; }
        public int StorefrontId { get; set; }
        public bool Show { get; set; }
        public string? InternalNotes { get; set; }
    }
}
