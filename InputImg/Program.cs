using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputImg
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = ConfigurationManager.AppSettings["ExcelPath"];
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ path + ";" +
"Extended Properties='Excel 8.0'";
            DataSet ds = new DataSet();
           
        }

    }
}
