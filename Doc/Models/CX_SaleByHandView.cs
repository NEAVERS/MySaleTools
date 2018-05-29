using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CX_SaleByHandView
    {
        public decimal BillNumberId { get; set; }
        public string SaleType { get; set; }
        public string MoneyTicket { get; set; }
        public string GoodsPro { get; set; }
        public string ChoosePro { get; set; }
        public string TotalMoney { get; set; }
        public string TotalQty { get; set; }
        public string Discount { get; set; }
        public string RebateMoney { get; set; }
        public string MoneyAdd { get; set; }
    }
}
