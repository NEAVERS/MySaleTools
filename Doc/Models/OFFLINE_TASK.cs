using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OFFLINE_TASK
    {
        public int ID { get; set; }
        public string FILENAME { get; set; }
        public System.DateTime DATE { get; set; }
        public string FLAG { get; set; }
        public int TASKID { get; set; }
        public int STATUS { get; set; }
        public string STOCKID { get; set; }
    }
}
