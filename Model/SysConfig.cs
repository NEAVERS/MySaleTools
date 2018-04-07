using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SysConfig
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string  Value { get; set; }

        public DateTime UpdateTime { get; set; }

        public Guid UpdateUser { get; set; }

    }
}
