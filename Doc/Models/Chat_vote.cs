using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Chat_vote
    {
        public int ID { get; set; }
        public Nullable<int> exp_num { get; set; }
        public string votename { get; set; }
        public string voteoptions { get; set; }
        public Nullable<int> votenum { get; set; }
        public string voted_user { get; set; }
        public Nullable<System.DateTime> begin_time { get; set; }
        public Nullable<System.DateTime> end_flag { get; set; }
    }
}
