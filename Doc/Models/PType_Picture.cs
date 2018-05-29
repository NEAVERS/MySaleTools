using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PType_Picture
    {
        public string PTypeID { get; set; }
        public string Name { get; set; }
        public decimal OrderID { get; set; }
        public string ImgURL { get; set; }
        public byte[] pic { get; set; }
        public Nullable<int> length { get; set; }
        public string filename { get; set; }
        public string type { get; set; }
    }
}
