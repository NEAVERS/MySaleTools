using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class BillPrintConfig
    {
        public int ID { get; set; }
        public int BillTypes { get; set; }
        public int BillType { get; set; }
        public int AddState { get; set; }
        public int SaveState { get; set; }
        public int PassState { get; set; }
        public int SaveAlert { get; set; }
        public int PassAlert { get; set; }
        public int PrintNum { get; set; }
        public int SortID { get; set; }
    }
}
