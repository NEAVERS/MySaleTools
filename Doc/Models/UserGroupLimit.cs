using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class UserGroupLimit
    {
        public int ID { get; set; }
        public int EtypeID { get; set; }
        public string Lim { get; set; }
        public string MangerETypeID { get; set; }
        public string MangerPTypeID { get; set; }
        public string MangerKTypeID { get; set; }
        public string MangerSTypeID { get; set; }
        public string MangerDTypeID { get; set; }
        public string MangerBTypeID { get; set; }
        public string MangerBTypeID2 { get; set; }
        public string MangerATypeID { get; set; }
        public string MangerRevenue { get; set; }
        public string MangerOwnerEquity { get; set; }
        public string MangerExpense { get; set; }
        public string MangerIncome { get; set; }
        public string MangerCpaital { get; set; }
        public string MangerOtherCpaital { get; set; }
        public string MangerLiabilities { get; set; }
        public string MangerPay { get; set; }
        public string MangerBankID { get; set; }
    }
}
