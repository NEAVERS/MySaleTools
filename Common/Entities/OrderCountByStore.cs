using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class OrderCountByStore
    {
        public int Num { get; set; }

        public string StoreNum { get; set; }

        public string StoreName { get; set; }

        public int  OrderCount { get; set; }

        public decimal TotalMoeny { get; set; }

        public decimal TotalRealMoney { get; set; }

        public decimal TotalPayMoney { get; set; }

        public string Tel { get; set; }

        public string  Addr { get; set; }

        public string UserType { get; set; }

        public string SaleMan { get; set; }

        public string  Areas { get; set; }
    }
}
