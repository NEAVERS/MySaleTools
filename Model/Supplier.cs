using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Supplier
    {
        /// <summary>
        /// 供应商Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 供应商编号
        /// </summary>
        public string SupplierNum { get; set; }
        /// <summary>
        /// 供应商名字
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 供应商公司
        /// </summary>
        public string SupplierCompany { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 创建人用户ID
        /// </summary>
        public Guid CreateUserId { get; set; }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
