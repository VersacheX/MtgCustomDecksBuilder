using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UspsScanFile
    {
        public UspsScanFile()
        {
            UspsScanFileEvents = new HashSet<UspsScanFileEvent>();
        }

        public int Id { get; set; }
        public byte SettingId { get; set; }
        public string? FileName { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ImportedOn { get; set; }

        public virtual ICollection<UspsScanFileEvent> UspsScanFileEvents { get; set; }
    }
}
