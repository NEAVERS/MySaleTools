using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserResourse
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public string  Resourse { get; set; }

        public DateTime CreateTime { get; set; }

        public UserResourse()
        {
            this.CreateTime = DateTime.Now;
            this.UserId = Guid.Empty;
            this.Resourse = string.Empty;
        }

    }
}
