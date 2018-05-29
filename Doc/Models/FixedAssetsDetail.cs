using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class FixedAssetsDetail
    {
        public decimal ID { get; set; }
        public string BillNumberID { get; set; }
        public Nullable<int> AssertsCardId { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public Nullable<int> barcode { get; set; }
        public Nullable<int> acstate { get; set; }
        public string panbarcode { get; set; }
        public Nullable<int> panstate { get; set; }
        public string comment { get; set; }
    }
}
