using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Chat_vrecord
    {
        public int ID { get; set; }
        public string username { get; set; }
        public Nullable<int> votetype { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<int> temp_level { get; set; }
    }
}
