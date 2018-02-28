using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Area
    {
        public int Id { get; set; }

        /// <summary>
        /// 区域编号
        /// </summary>
        public string Num { get; set; }
        /// <summary>
        /// 区域名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 上级区域编号
        /// </summary>
        public string ParentNum { get; set; }
        /// <summary>
        /// 上级区域名
        /// </summary>
        public string ParentName { get; set; }
    }
}
