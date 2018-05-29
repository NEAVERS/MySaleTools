using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CM_CarUseBill
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string Comment { get; set; }
        public int CarId { get; set; }
        public string Driver { get; set; }
        public string Etypeid { get; set; }
        public string Destination { get; set; }
        public string Use { get; set; }
        public System.DateTime Usestartdate { get; set; }
        public System.DateTime Useenddate { get; set; }
    }
}
