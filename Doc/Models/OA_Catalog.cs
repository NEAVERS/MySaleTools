using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OA_Catalog
    {
        public int ID { get; set; }
        public string TypeID { get; set; }
        public string ParentID { get; set; }
        public Nullable<int> SonNumber { get; set; }
        public Nullable<int> SonCounter { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FontColor { get; set; }
        public string ImgFileName { get; set; }
        public int Expand { get; set; }
        public int IsFlowCheck { get; set; }
        public int IsCascadeCheck { get; set; }
        public int ClickNumber { get; set; }
        public int SplitBanner { get; set; }
        public string SplitImg { get; set; }
    }
}
