using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class HR_TaskDistribution
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public int Task_ID { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<System.DateTime> DeadTime { get; set; }
        public int Person_ID { get; set; }
        public int TaskStatus_ID { get; set; }
        public string Remark { get; set; }
    }
}
