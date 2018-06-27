using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DiscountInfo
    {
        public Guid Id { get; set; }

        public Guid TypeId { get; set; }

        public String TypeName{ get; set; }

        public decimal Discount { get; set; }

        public DateTime UpdateTime { get; set; }

        public Guid UpdateUserId { get; set; }

        public string UserTypes { get; set; }

        public string UpdateUserName { get; set; }

        public DateTime EndTime { get; set; }


        public DateTime StartTime { get; set; }


    }
}
