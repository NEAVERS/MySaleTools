using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Sms_ReceiveLog
    {
        public int ID { get; set; }
        public string PhoneNo { get; set; }
        public string QryCode { get; set; }
        public string Content { get; set; }
        public string RecSTime { get; set; }
        public string RecCTime { get; set; }
        public string Response { get; set; }
        public int SendError { get; set; }
        public int State { get; set; }
        public int SmsType { get; set; }
        public string SendId { get; set; }
        public string OperID { get; set; }
        public int Deleted { get; set; }
    }
}
