using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MailExpressTrackingEvent
    {
        public int EventId { get; set; }
        public int ImportId { get; set; }
        public string PackageId1 { get; set; } = null!;
        public string? PackageId2 { get; set; }
        public string? CosigneeName { get; set; }
        public string? CosigneeCompany { get; set; }
        public string? CosigneeAddress { get; set; }
        public string? CosigneeAddress2 { get; set; }
        public string? CosigneeCity { get; set; }
        public string? CosigneeState { get; set; }
        public string? CosigneeZip { get; set; }
        public decimal? Weight { get; set; }
        public string EventCode { get; set; } = null!;
        public string? EventSource { get; set; }
        public string? EventCity { get; set; }
        public string? EventState { get; set; }
        public string? EventZip { get; set; }
        public DateTime EventDate { get; set; }

        public virtual MailExpressTrackingEventCode EventCodeNavigation { get; set; } = null!;
        public virtual MailExpressTrackingImport Import { get; set; } = null!;
    }
}
