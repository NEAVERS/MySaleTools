using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class HR_InterviewerEstimate
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public int Times { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Nullable<int> Score { get; set; }
        public int Person_ID { get; set; }
        public string HR_ID { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    }
}
