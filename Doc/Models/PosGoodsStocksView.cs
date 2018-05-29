using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosGoodsStocksView
    {
        public int OrderID { get; set; }
        public string ptypeid { get; set; }
        public string ktypeid { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<int> GoodsOrder { get; set; }
        public int RowOrder { get; set; }
        public string cBYZD { get; set; }
        public int iBYZD { get; set; }
        public int nBYZD { get; set; }
    }
}
