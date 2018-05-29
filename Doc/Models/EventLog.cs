using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class EventLog
    {
        public decimal Id { get; set; }
        public System.DateTime EventDate { get; set; }
        public string etypeid { get; set; }
        public string EventId { get; set; }
        public string Ip { get; set; }
        public string Deleted { get; set; }
    }
}
