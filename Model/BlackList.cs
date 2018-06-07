using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BlackList
    {
        public Guid Id { get; set; }

        public Guid GoodsId { get; set; }

        public string GoodsName { get; set; }


        public DateTime CreateTime { get; set; }

        public Guid CreateUserId { get; set; }

        public string CreateUserName { get; set; }

        public bool IsDelete { get; set; }
    }
}
