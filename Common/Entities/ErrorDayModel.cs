using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public  class ErrorDayModel
    {
        public string Suplier { get; set; }

        public string  ProductId { get; set; }

        public string  ProductName { get; set; }

        public string  Spec { get; set; }

        public string Unit { get; set; }

        public int  ErrorCount { get; set; }

        public int ErrorDays { get; set; }
    }
}
