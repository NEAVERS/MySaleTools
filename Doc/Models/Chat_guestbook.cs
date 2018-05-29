using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Chat_guestbook
    {
        public int ID { get; set; }
        public string who { get; set; }
        public string towho { get; set; }
        public Nullable<bool> secret { get; set; }
        public string ip { get; set; }
        public string email { get; set; }
        public string web { get; set; }
        public string addr { get; set; }
        public Nullable<System.DateTime> post_time { get; set; }
        public string text_title { get; set; }
        public string text_body { get; set; }
    }
}
