using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsSample
    {
        public ProdsSample()
        {
            ProdsSamplesInbounds = new HashSet<ProdsSamplesInbound>();
            ProdsSamplesInventories = new HashSet<ProdsSamplesInventory>();
            ProdsSamplesProdsRelationshipExcludes = new HashSet<ProdsSamplesProdsRelationshipExclude>();
            ProdsSamplesProdsRelationships = new HashSet<ProdsSamplesProdsRelationship>();
            ProdsSamplesStorefronts = new HashSet<ProdsSamplesStorefront>();
        }

        public int SampleId { get; set; }
        public string? SampleUpc { get; set; }
        public string? SampleName { get; set; }
        public decimal? InsertFeeToStorefrontObsolete { get; set; }
        public bool Inactive { get; set; }
        public string? SampleNotes { get; set; }

        public virtual ICollection<ProdsSamplesInbound> ProdsSamplesInbounds { get; set; }
        public virtual ICollection<ProdsSamplesInventory> ProdsSamplesInventories { get; set; }
        public virtual ICollection<ProdsSamplesProdsRelationshipExclude> ProdsSamplesProdsRelationshipExcludes { get; set; }
        public virtual ICollection<ProdsSamplesProdsRelationship> ProdsSamplesProdsRelationships { get; set; }
        public virtual ICollection<ProdsSamplesStorefront> ProdsSamplesStorefronts { get; set; }
    }
}
