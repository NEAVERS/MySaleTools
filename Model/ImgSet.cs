using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ImgSet
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Ttile { get; set; }
        /// <summary>
        /// 图片链接
        /// </summary>
        public  string  ImgUrl { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        public string TurnUrl { get; set; }

        /// <summary>
        /// 海报类型
        /// </summary>
        public string  ImgType { get; set; }
        /// <summary>
        /// 排序Id
        /// </summary>
        public int SortedId { get; set; }


        public ImgSet()
        {
            this.Id = Guid.NewGuid();
            this.Ttile = string.Empty;
            this.ImgUrl = string.Empty;
            this.TurnUrl = string.Empty;
            this.ImgType = string.Empty;
            this.SortedId = 0;
        }

    }

}
