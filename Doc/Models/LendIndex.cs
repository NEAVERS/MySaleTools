using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class LendIndex
    {
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public decimal BillType { get; set; }
        public string Comment { get; set; }
        public string atypeid { get; set; }
        public string ptypeid { get; set; }
        public string btypeid { get; set; }
        public string dealbtypeid { get; set; }
        public string etypeid { get; set; }
        public string ktypeid { get; set; }
        public string ktypeid2 { get; set; }
        public string ifcheck { get; set; }
        public string checke { get; set; }
        public Nullable<decimal> totalmoney { get; set; }
        public Nullable<decimal> totalinmoney { get; set; }
        public Nullable<decimal> totalqty { get; set; }
        public Nullable<decimal> tax { get; set; }
        public Nullable<short> period { get; set; }
        public string explain { get; set; }
        public Nullable<int> RedWord { get; set; }
        public bool draft { get; set; }
        public Nullable<decimal> OrderId { get; set; }
        public string waybillcode { get; set; }
        public Nullable<decimal> goodsnumber { get; set; }
        public string packway { get; set; }
        public string TEL { get; set; }
        public bool Uploaded { get; set; }
        public Nullable<System.Guid> OFF_ID { get; set; }
        public string DTypeID { get; set; }
        public decimal ID { get; set; }
        public string IfAudit { get; set; }
        public string Stypeid { get; set; }
        public Nullable<bool> IsIni { get; set; }
        public string redreason { get; set; }
        public string Poster { get; set; }
        public Nullable<System.DateTime> posttime { get; set; }
        public Nullable<System.DateTime> checkTime { get; set; }
        public Nullable<int> ifYearBill { get; set; }
        public string UpdateE { get; set; }
    }
}
