using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class xw_Message
    {
        public int C_Id { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public System.DateTime SendDate { get; set; }
        public string Message { get; set; }
        public bool IsNew { get; set; }
        public bool Deleted { get; set; }
    }
}
