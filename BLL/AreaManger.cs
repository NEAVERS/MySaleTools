using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class AreaManger
    {
        private SaleToolsContext _context = new SaleToolsContext();

        public List<Area> GetAreaList(string parentNum = "0")
        {
            var q = _context.Areas.Where(x => x.ParentNum == parentNum);
            return q.ToList();
        }

    }
}
