using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Chat_room
    {
        public int ID { get; set; }
        public string room_name { get; set; }
        public string room_auto { get; set; }
        public string room_owner { get; set; }
        public string room_des { get; set; }
        public string room_ref { get; set; }
        public string room_title { get; set; }
        public Nullable<bool> room_keep { get; set; }
        public Nullable<System.DateTime> room_time { get; set; }
        public Nullable<bool> room_html { get; set; }
        public Nullable<bool> ip_protect { get; set; }
    }
}
