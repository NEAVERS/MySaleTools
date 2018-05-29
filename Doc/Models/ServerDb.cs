using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ServerDb
    {
        public int serverdbId { get; set; }
        public string name { get; set; }
        public string ip { get; set; }
        public string pcName { get; set; }
        public string dbName { get; set; }
        public string dbLogin { get; set; }
        public string dbPwd { get; set; }
        public string connectionString { get; set; }
    }
}
