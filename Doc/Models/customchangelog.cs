using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class customchangelog
    {
        public int id { get; set; }
        public System.DateTime dateTime { get; set; }
        public string ipAddress { get; set; }
        public string formname { get; set; }
        public string datafiled { get; set; }
        public string label { get; set; }
        public string changefiled { get; set; }
        public string logtext { get; set; }
        public string loginUserId { get; set; }
    }
}
