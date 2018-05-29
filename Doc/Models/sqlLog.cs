using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class sqlLog
    {
        public int id { get; set; }
        public byte type { get; set; }
        public System.DateTime dateTime { get; set; }
        public int elapsed { get; set; }
        public string url { get; set; }
        public string @params { get; set; }
        public string ipAddress { get; set; }
        public string C_sql { get; set; }
        public int executeElapsed { get; set; }
        public int fetchElapsed { get; set; }
        public int C_rowCount { get; set; }
        public string error { get; set; }
        public string profileId { get; set; }
        public string loginUserId { get; set; }
    }
}
