using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 满减
    /// </summary>
    public class Manjiujian
    {
        public Guid Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public decimal LimitMoney { get; set; }

        public decimal LessMoeny { get; set; }

        public string UserTypes { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid CreateUserId { get; set; }

    }
}
