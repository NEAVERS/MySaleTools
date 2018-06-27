using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class DiscountDetail
    {
        public DiscountInfo Info { get; set; }

        public List<ManToArea> Areas { get; set; }
    }
}
