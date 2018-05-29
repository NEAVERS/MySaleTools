using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Chat_user
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string passwd { get; set; }
        public Nullable<bool> sex { get; set; }
        public Nullable<int> user_level { get; set; }
        public Nullable<System.DateTime> log_time { get; set; }
        public Nullable<int> visit_num { get; set; }
        public Nullable<System.DateTime> in_time { get; set; }
        public Nullable<int> out_info { get; set; }
        public Nullable<System.DateTime> out_time { get; set; }
        public Nullable<int> exp_num { get; set; }
        public Nullable<int> f_size { get; set; }
        public Nullable<int> l_height { get; set; }
        public Nullable<int> n_color { get; set; }
        public Nullable<int> s_color { get; set; }
        public string email { get; set; }
        public string remand { get; set; }
        public string answer { get; set; }
        public string bgcolor { get; set; }
        public string temppass { get; set; }
        public string oicq { get; set; }
        public Nullable<bool> saved { get; set; }
    }
}
