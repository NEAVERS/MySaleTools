using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommonPosSaleList
    {
        public int PosVchCode { get; set; }
        public int ListID { get; set; }
        public string PtypeID { get; set; }
        public Nullable<int> ColorID { get; set; }
        public Nullable<int> SizeID { get; set; }
        public decimal Qty { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal DisCount { get; set; }
        public decimal DisCountRate { get; set; }
        public decimal Price { get; set; }
        public decimal Sum { get; set; }
        public int IsPresent { get; set; }
        public string CXBillID { get; set; }
        public decimal CXJFXS { get; set; }
        public int IsUpSend { get; set; }
        public int UpLoadPosVchCode { get; set; }
        public string UniqueID { get; set; }
        public string ListRow { get; set; }
    }
}
