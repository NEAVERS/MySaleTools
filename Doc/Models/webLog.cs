using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class webLog
    {
        public int id { get; set; }
        public byte type { get; set; }
        public int status { get; set; }
        public System.DateTime dateTime { get; set; }
        public int elapsed { get; set; }
        public int businessElapsed { get; set; }
        public string url { get; set; }
        public string @params { get; set; }
        public string referrer { get; set; }
        public string ipAddress { get; set; }
        public string ipLocation { get; set; }
        public string browser { get; set; }
        public string profileId { get; set; }
        public string loginUserId { get; set; }
    }
}
