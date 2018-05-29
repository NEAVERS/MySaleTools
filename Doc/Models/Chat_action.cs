using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Chat_action
    {
        public int ID { get; set; }
        public string act_name { get; set; }
        public string alias { get; set; }
        public string toall { get; set; }
        public string toself { get; set; }
        public string toother { get; set; }
    }
}
