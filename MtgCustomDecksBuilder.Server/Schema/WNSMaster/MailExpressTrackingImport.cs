using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MailExpressTrackingImport
    {
        public MailExpressTrackingImport()
        {
            MailExpressTrackingEvents = new HashSet<MailExpressTrackingEvent>();
        }

        public int ImportId { get; set; }
        public string FileName { get; set; } = null!;
        public DateTime DateOfImport { get; set; }

        public virtual ICollection<MailExpressTrackingEvent> MailExpressTrackingEvents { get; set; }
    }
}
