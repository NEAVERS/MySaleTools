using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Offline_BillIndex
    {
        public System.Guid OFF_ID { get; set; }
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public decimal BillType { get; set; }
        public string Comment { get; set; }
        public string atypeid { get; set; }
        public string ptypeid { get; set; }
        public string btypeid { get; set; }
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
        public bool RedWord { get; set; }
        public bool draft { get; set; }
        public Nullable<decimal> OrderId { get; set; }
        public string waybillcode { get; set; }
        public Nullable<decimal> goodsnumber { get; set; }
        public string packway { get; set; }
        public string TEL { get; set; }
        public Nullable<int> Status { get; set; }
        public string StockName { get; set; }
        public int TaskID { get; set; }
        public int Import { get; set; }
        public string STOCKID { get; set; }
        public Nullable<int> AlertDay { get; set; }
        public Nullable<decimal> CompleteTotal { get; set; }
        public string Assessor { get; set; }
        public string IfAudit { get; set; }
        public string Audit_explain { get; set; }
        public Nullable<decimal> ID { get; set; }
    }
}
