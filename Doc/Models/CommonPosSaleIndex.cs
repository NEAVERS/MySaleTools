using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CommonPosSaleIndex
    {
        public int PosVchCode { get; set; }
        public string BillCode { get; set; }
        public string Branchid { get; set; }
        public string BtypeID { get; set; }
        public string KtypeID { get; set; }
        public string Cashier { get; set; }
        public string Salesman { get; set; }
        public int VipCardID { get; set; }
        public decimal Total { get; set; }
        public decimal BillDiscount { get; set; }
        public decimal Efface { get; set; }
        public decimal FinallyTotal { get; set; }
        public string PosID { get; set; }
        public string SaleDate { get; set; }
        public string SaleTime { get; set; }
        public int Draft { get; set; }
        public int DraftVchcode { get; set; }
        public decimal CashSum { get; set; }
        public decimal CreditSum { get; set; }
        public decimal ReplaceCashSum { get; set; }
        public decimal SaveAccountSum { get; set; }
        public decimal ChangeSum { get; set; }
        public decimal VipIntegral { get; set; }
        public int BackGoodsVchCode { get; set; }
        public decimal SGCXBillID { get; set; }
        public decimal RetReplaceCashSum { get; set; }
        public int IsUpSend { get; set; }
        public int UpLoadPosVchCode { get; set; }
        public string UniqueID { get; set; }
    }
}
