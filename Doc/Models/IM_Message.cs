using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IM_Message
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string BillNumberID { get; set; }
        public string BillCode { get; set; }
        public Nullable<int> BillType { get; set; }
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string MessageType { get; set; }
        public string CreateDate { get; set; }
        public int IsRead { get; set; }
        public string SenderIP { get; set; }
        public string ReceiverIP { get; set; }
    }
}
