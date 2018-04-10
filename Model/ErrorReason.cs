using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ErrorReason
    {
        public int Id { get; set; }

        public int  ErrorCode { get; set; }

        /// <summary>
        /// 1 异常类型 2为异常原因
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 上级ID
        /// </summary>
        public int ParentCode { get; set; }

        /// <summary>
        /// 具体信息
        /// </summary>
        public string Info { get; set; }
    }
}
