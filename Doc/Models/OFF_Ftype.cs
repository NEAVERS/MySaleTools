using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OFF_Ftype
    {
        public int NUM { get; set; }
        public string barname { get; set; }
        public int layer1 { get; set; }
        public int layer2 { get; set; }
        public int layer3 { get; set; }
        public int layer4 { get; set; }
        public int layer5 { get; set; }
        public int layer6 { get; set; }
        public string bardescript { get; set; }
        public string url { get; set; }
        public Nullable<int> parent { get; set; }
        public Nullable<int> son { get; set; }
        public int soncount { get; set; }
        public Nullable<int> levelnum { get; set; }
        public string powername0 { get; set; }
        public string powername1 { get; set; }
        public string powername2 { get; set; }
        public string powername3 { get; set; }
        public string powername4 { get; set; }
        public int store { get; set; }
        public Nullable<int> nsave { get; set; }
        public Nullable<int> breed { get; set; }
        public int AllSee { get; set; }
        public string room_name { get; set; }
        public string room_auto { get; set; }
        public string room_owner { get; set; }
        public string room_des { get; set; }
        public string room_ref { get; set; }
        public string room_title { get; set; }
        public Nullable<bool> room_keep { get; set; }
        public string room_time { get; set; }
        public string room_html { get; set; }
        public Nullable<bool> ip_protect { get; set; }
    }
}
