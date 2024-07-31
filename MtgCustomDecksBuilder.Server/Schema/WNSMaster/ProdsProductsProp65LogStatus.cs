using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsProp65LogStatus
    {
        public ProdsProductsProp65LogStatus()
        {
            ProdsProductsProp65Logs = new HashSet<ProdsProductsProp65Log>();
        }

        public int Id { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<ProdsProductsProp65Log> ProdsProductsProp65Logs { get; set; }
    }
}
