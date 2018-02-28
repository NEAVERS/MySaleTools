using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PriceOfUserType
    {
        public int Id { get; set; }
        public Guid GoodsId { get; set; }

        public int UserTypeId { get; set; }

        public decimal Price { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
