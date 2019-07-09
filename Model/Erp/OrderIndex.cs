using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Erp
{
    public partial class OrderIndex
    {
        public decimal billNumberId { get; set; }
        public string btypeid { get; set; }
        public string etypeid { get; set; }
        public string ktypeid { get; set; }
        public DateTime BillDate { get; set; }
        public Nullable<System.DateTime> ReachDate { get; set; }
        public string Billcode { get; set; }
        public short billtype { get; set; }
        public Nullable<decimal> totalmoney { get; set; }
        public Nullable<decimal> totalqty { get; set; }
        public short period { get; set; }
        public bool @checked { get; set; }
        public bool redWord { get; set; }
        public bool BillOver { get; set; }
        public string comment { get; set; }
        public string explain { get; set; }
        public string Checke { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public int BillStatus { get; set; }
        public string etypeid2 { get; set; }
        public string WayMode { get; set; }
        public string WayBillCode { get; set; }
        public string GoodsNumber { get; set; }
        public string PackWay { get; set; }
        public string TEL { get; set; }
        public Nullable<int> IfAudit { get; set; }
        public string DtypeId { get; set; }
        public Nullable<int> IsFinished { get; set; }
        public string CanAlert { get; set; }
        public string DelayType { get; set; }
        public string DelayValue { get; set; }
        public string OrderState { get; set; }
        public string Stypeid { get; set; }
        public Nullable<decimal> FromBillNumberID { get; set; }
        public Nullable<decimal> CustomerTotal { get; set; }
        public Nullable<bool> IsIni { get; set; }
        public Nullable<decimal> Ntotalmoney { get; set; }
        public Nullable<int> CID { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> billproperty { get; set; }
        public int PrePriceNum { get; set; }
        public Nullable<bool> IsYapi { get; set; }
        public string YapiOrderID { get; set; }
        public Nullable<decimal> NCustomerTotal { get; set; }
        public string DealBTypeID { get; set; }
        public string atypeID { get; set; }
        public Nullable<decimal> totalinmoney { get; set; }
        public Nullable<decimal> ntotalinmoney { get; set; }
        public Nullable<System.DateTime> checkTime { get; set; }
        public Nullable<decimal> Discount { get; set; }



    }
}
