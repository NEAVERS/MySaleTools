using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 公告
    /// </summary>
    public class Notice
    {

        public int Id { get; set; }

        public string Tittle { get; set; }


        public string Content { get; set; }

        public string UserTypes { get; set; }


        public DateTime CreateTime { get; set; }

        public Guid CreateUserId { get; set; }

        public string CreattUserName { get; set; }

        public bool IsDelete { get; set; }
    }
}
