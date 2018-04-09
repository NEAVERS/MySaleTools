using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class PickUpModel
    {
        public string OrderNum { get; set; }

        public DateTime  CreateTime { get; set; }

        public string Mark { get; set; }

        public List<GetProductItem> Items { get; set; }

    }
}
