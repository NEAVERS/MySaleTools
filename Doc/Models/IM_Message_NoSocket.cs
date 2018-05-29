using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class IM_Message_NoSocket
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TypeID { get; set; }
        public string BillCode { get; set; }
        public Nullable<int> BillType { get; set; }
        public string SenderID { get; set; }
        public string SenderName { get; set; }
        public string ReceiverID { get; set; }
        public string ReceiverName { get; set; }
        public string MessageType { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int IsRead { get; set; }
        public string SenderIP { get; set; }
        public string ReceiverIP { get; set; }
        public int BillNumberId { get; set; }
    }
}
