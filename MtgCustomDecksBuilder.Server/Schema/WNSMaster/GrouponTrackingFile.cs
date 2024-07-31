using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GrouponTrackingFile
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UploadedOn { get; set; }
    }
}
