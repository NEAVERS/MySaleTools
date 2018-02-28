using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserType
    {
        /// <summary>
        /// 类型Id
        /// </summary>
        public int TypeId { get; set; }



        /// <summary>
        /// 类型
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 是否为管理员
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}
