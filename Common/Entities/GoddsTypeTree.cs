using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Common.Entities
{
    public class GoddsTypeTree
    {
        public GoodsType GoodsType { get; set; }

        public List<GoddsTypeTree> TypeList { get; set; }

        public GoddsTypeTree(GoodsType type)
        {
            this.GoodsType = type;
            this.TypeList = new List<GoddsTypeTree>();
        }

        public GoddsTypeTree(GoodsType type,List<GoodsType> list)
        {
            this.GoodsType = type;
            this.TypeList = new List<GoddsTypeTree>();
            list.ForEach(x =>
            {
                this.TypeList.Add(new GoddsTypeTree(x));
            });
        }

    }
}
