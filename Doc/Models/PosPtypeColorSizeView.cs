using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosPtypeColorSizeView
    {
        public string ptypeid { get; set; }
        public int ColorID { get; set; }
        public int SizeID { get; set; }
        public int sizeorderid { get; set; }
        public int colororderid { get; set; }
        public Nullable<decimal> updatetag { get; set; }
    }
}
