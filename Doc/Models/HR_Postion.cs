using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class HR_Postion
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department_ID { get; set; }
        public string Intro { get; set; }
        public string Remark { get; set; }
    }
}
