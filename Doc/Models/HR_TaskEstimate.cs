using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class HR_TaskEstimate
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public string Content { get; set; }
        public int Task_ID { get; set; }
        public int Person_ID { get; set; }
        public int HR_ID { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    }
}
