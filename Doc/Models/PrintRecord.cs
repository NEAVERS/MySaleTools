using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PrintRecord
    {
        public decimal BillType { get; set; }
        public decimal BillNumberId { get; set; }
        public string etypeid { get; set; }
        public System.DateTime PrintTime { get; set; }
        public string Ip { get; set; }
        public Nullable<int> PrintCount { get; set; }
        public string eFullName { get; set; }
        public Nullable<int> BillState { get; set; }
        public string billcode { get; set; }
        public short RecordState { get; set; }
    }
}
