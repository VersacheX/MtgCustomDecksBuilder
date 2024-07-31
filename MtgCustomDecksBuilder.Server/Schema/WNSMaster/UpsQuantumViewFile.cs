using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsQuantumViewFile
    {
        public UpsQuantumViewFile()
        {
            UpsQuantumViews = new HashSet<UpsQuantumView>();
        }

        public int FileId { get; set; }
        public string UpsfileName { get; set; } = null!;
        public string LocalFileName { get; set; } = null!;
        public DateTime DateAndTime { get; set; }

        public virtual ICollection<UpsQuantumView> UpsQuantumViews { get; set; }
    }
}
