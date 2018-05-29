using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class HR_Task
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public Nullable<int> IntendingDays { get; set; }
        public int Postion_ID { get; set; }
        public string Remark { get; set; }
        public Nullable<int> StatusID { get; set; }
    }
}
