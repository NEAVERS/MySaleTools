using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosGoodsStocksDetailView
    {
        public Nullable<int> OrderID { get; set; }
        public string ptypeid { get; set; }
        public string Ktypeid { get; set; }
        public int colorid { get; set; }
        public int sizeid { get; set; }
        public Nullable<decimal> qty { get; set; }
        public int Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string cBYZD { get; set; }
        public int iBYZD { get; set; }
        public int nBYZD { get; set; }
    }
}
