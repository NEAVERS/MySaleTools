using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class V_LendFace
    {
        public string pUserCode { get; set; }
        public string pFullName { get; set; }
        public string pEntryCode { get; set; }
        public string pTypeID { get; set; }
        public string kUserCode { get; set; }
        public string kFullName { get; set; }
        public string kTypeID { get; set; }
        public string bUserCode { get; set; }
        public string bFullName { get; set; }
        public string bTypeID { get; set; }
        public string dealbtypeid { get; set; }
        public string eUserCode { get; set; }
        public string eFullName { get; set; }
        public string eTypeID { get; set; }
        public decimal BillNumberID { get; set; }
        public System.DateTime BillDate { get; set; }
        public decimal BillType { get; set; }
        public string BillCode { get; set; }
        public string Comment { get; set; }
        public string STypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> IsCombined { get; set; }
        public Nullable<decimal> NQty { get; set; }
        public string GoodsNumber { get; set; }
        public string producedate { get; set; }
        public string ValidDate { get; set; }
        public int CustomdetailID { get; set; }
        public string ifcheck { get; set; }
        public Nullable<int> RedWord { get; set; }
        public bool Draft { get; set; }
        public Nullable<decimal> Borrow { get; set; }
        public Nullable<decimal> BorrowBack { get; set; }
        public Nullable<decimal> Lend { get; set; }
        public Nullable<decimal> LendBack { get; set; }
        public Nullable<decimal> NBorrow { get; set; }
        public Nullable<decimal> NBorrowBack { get; set; }
        public Nullable<decimal> NLend { get; set; }
        public Nullable<decimal> NLendBack { get; set; }
        public Nullable<decimal> buyqty { get; set; }
        public Nullable<decimal> saleqty { get; set; }
    }
}
