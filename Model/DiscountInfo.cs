using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DiscountInfo
    {
        public int Id { get; set; }

        public Guid TypeId { get; set; }

        public String TypeName{ get; set; }

        public decimal Discount { get; set; }

        public DateTime UpdateTime { get; set; }

        public Guid UpdateUserId { get; set; }

        public string UpdateUserName { get; set; }

    }
}
