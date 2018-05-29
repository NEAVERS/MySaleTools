using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Crm_Message
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string SenderTypeID { get; set; }
        public string ReceiverTypeID { get; set; }
        public string Content { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public string CreatorTypeID { get; set; }
        public string Type { get; set; }
        public System.DateTime BeginDate { get; set; }
        public string Source { get; set; }
        public int SourceTypeID { get; set; }
        public System.DateTime ReadTime { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public int SendMsgID { get; set; }
    }
}
