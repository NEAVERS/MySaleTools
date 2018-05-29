using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Voucher_Bill_Temp
    {
        public Nullable<decimal> BillNumberId { get; set; }
        public string explain { get; set; }
        public string usercode { get; set; }
        public string fullname { get; set; }
        public string typeid { get; set; }
        public Nullable<int> sysrow { get; set; }
        public Nullable<int> cid { get; set; }
        public Nullable<int> moneytype { get; set; }
        public Nullable<int> basisType { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<decimal> balanceprice { get; set; }
        public Nullable<decimal> lendprice { get; set; }
        public Nullable<decimal> loanprice { get; set; }
        public string FSettleNo { get; set; }
        public Nullable<int> FSettleTypeID { get; set; }
        public string comment { get; set; }
        public string STypeId { get; set; }
        public Nullable<int> Fdc { get; set; }
        public Nullable<int> fadc { get; set; }
        public Nullable<int> facnt { get; set; }
        public Nullable<int> FCashFlowItem { get; set; }
        public Nullable<int> rowno { get; set; }
        public Nullable<decimal> id { get; set; }
        public string MainItems { get; set; }
        public string AdditionItems { get; set; }
        public Nullable<long> KeyId { get; set; }
        public Nullable<int> iscash { get; set; }
        public Nullable<int> isbank { get; set; }
        public Nullable<int> IsDiary { get; set; }
        public Nullable<int> isother { get; set; }
        public Nullable<int> mcid { get; set; }
        public string mainitemsid { get; set; }
        public string additionitemsid { get; set; }
        public string mainitemsname { get; set; }
        public string additionitemsname { get; set; }
        public string assist { get; set; }
        public string asslist { get; set; }
        public string balancenum { get; set; }
        public Nullable<int> balancetype { get; set; }
        public string cUserCode { get; set; }
        public string cFullName { get; set; }
        public Nullable<int> islimit_ac { get; set; }
    }
}
