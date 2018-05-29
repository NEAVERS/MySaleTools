using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class UpdateVersionList
    {
        public int ListId { get; set; }
        public string VersionNo { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Nullable<int> SortId { get; set; }
    }
}
