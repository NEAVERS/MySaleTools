using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class HR_Img
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public byte[] pic { get; set; }
        public string filename { get; set; }
        public Nullable<int> length { get; set; }
        public Nullable<int> Person_ID { get; set; }
    }
}
