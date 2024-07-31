using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GrouponOrdersFile
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
    }
}
