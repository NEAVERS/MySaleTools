using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Chat_record
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> occ_time { get; set; }
        public string occ_env { get; set; }
        public string for_what { get; set; }
    }
}
