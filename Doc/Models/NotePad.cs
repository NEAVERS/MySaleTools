using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class NotePad
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> AlertTime { get; set; }
        public string Content { get; set; }
        public Nullable<int> Flag { get; set; }
        public string UserId { get; set; }
        public Nullable<int> Importance { get; set; }
        public Nullable<int> ScanTimes { get; set; }
    }
}
