using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MailExpressTrackingEventCode
    {
        public MailExpressTrackingEventCode()
        {
            MailExpressTrackingEvents = new HashSet<MailExpressTrackingEvent>();
        }

        public string EventCode { get; set; } = null!;
        public string EventCodeDesc { get; set; } = null!;

        public virtual ICollection<MailExpressTrackingEvent> MailExpressTrackingEvents { get; set; }
    }
}
