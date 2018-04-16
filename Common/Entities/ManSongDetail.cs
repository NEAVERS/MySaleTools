using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class ManDetail<T>
    {
        public T Info { get; set; }

        public List<Area> areas { get; set; }
    }
}
