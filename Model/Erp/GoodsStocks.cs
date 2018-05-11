using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Erp
{
    public class GoodsStocks
    {
        public string PtypeId { get; set; }

        public string KtypeId { get; set; }

        public string JobNumber { get; set; }

        public DateTime? OutFactoryDate { get; set; }

        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }

        public decimal? Total { get; set; }

        public int? GoodsOrder { get; set; }

        public string GoodsNumber { get; set; }

        public string ProduceDate { get; set; }

        public string ValidDate { get; set; }

        public string GoodsBTypeID { get; set; }
    }
}
