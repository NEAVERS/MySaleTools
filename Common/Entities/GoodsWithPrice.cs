using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class GoodsWithPrice
    {
        public GoodInfo info  { get; set; }

        public PriceOfUserType price { get; set; }
    }
}
