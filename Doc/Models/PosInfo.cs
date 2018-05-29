using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosInfo
    {
        public int PosID { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string ktypeid { get; set; }
        public string stypeid { get; set; }
        public string BtypeID { get; set; }
        public Nullable<int> BankCardID { get; set; }
        public Nullable<int> CashID { get; set; }
        public Nullable<int> VIPMoneyID { get; set; }
        public Nullable<int> IsBinding { get; set; }
        public string MacAddress { get; set; }
        public Nullable<int> STATE { get; set; }
        public string Comment { get; set; }
        public string PyCode { get; set; }
        public int PassType { get; set; }
        public Nullable<int> XiWaMaxNumber { get; set; }
        public int canclezeroway { get; set; }
        public int canclezerotype { get; set; }
        public int lowlowestsaleprice { get; set; }
        public int lowlastbuyprice { get; set; }
        public int highhighestsaleprice { get; set; }
        public int codesearchway { get; set; }
        public int stockqueryrange { get; set; }
        public int permitmakevipcard { get; set; }
        public int permitvipcardrecharge { get; set; }
        public int permitshowbatchno { get; set; }
        public int permitshowbatchtime { get; set; }
        public int permitsavenonnumber { get; set; }
        public int autoshowpromote { get; set; }
        public int rememberemployee { get; set; }
        public Nullable<int> KID { get; set; }
        public int rateid { get; set; }
        public int startbankrate { get; set; }
        public decimal PriceBillIndexID { get; set; }
        public int samegoodsumqty { get; set; }
        public int permitsaleemployee { get; set; }
        public int displayadvpic { get; set; }
        public int displayptypepic { get; set; }
        public int frequencysecond { get; set; }
    }
}
