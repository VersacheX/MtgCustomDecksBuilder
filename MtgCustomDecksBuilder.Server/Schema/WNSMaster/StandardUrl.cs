using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StandardUrl
    {
        public StandardUrl()
        {
            MetatagsBrands = new HashSet<MetatagsBrand>();
            MetatagsDepts = new HashSet<MetatagsDept>();
            MetatagsFams = new HashSet<MetatagsFam>();
            MetatagsKeywords = new HashSet<MetatagsKeyword>();
        }

        public int Urlid { get; set; }
        public string StdUrl { get; set; } = null!;
        public byte IsFile { get; set; }

        public virtual ICollection<MetatagsBrand> MetatagsBrands { get; set; }
        public virtual ICollection<MetatagsDept> MetatagsDepts { get; set; }
        public virtual ICollection<MetatagsFam> MetatagsFams { get; set; }
        public virtual ICollection<MetatagsKeyword> MetatagsKeywords { get; set; }
    }
}
