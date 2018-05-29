using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BBS_luntan
    {
        public int num { get; set; }
        public string title { get; set; }
        public string texts { get; set; }
        public string dates { get; set; }
        public string lastdates { get; set; }
        public string author { get; set; }
        public int reply { get; set; }
        public Nullable<int> new_number { get; set; }
        public Nullable<int> re_number { get; set; }
        public string img { get; set; }
        public int clicknum { get; set; }
        public Nullable<int> htmlcode { get; set; }
        public byte[] image { get; set; }
        public Nullable<int> imagelength { get; set; }
        public string imagetype { get; set; }
        public Nullable<int> haveimage { get; set; }
        public string filename { get; set; }
    }
}
