using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GoodsManager
    {
        private SaleToolsContext _context = new SaleToolsContext();


        /// <summary>
        /// 获取下级类型
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="createUserId"></param>
        /// <returns></returns>
        public List<GoodsType>  GetDownGoodsType(Guid parentId,Guid createUserId)
        {
            var q = _context.GoodsTypes.Where(x => x.ParentId == parentId&&x.CreateUserId == createUserId&&!x.IsDelete);
            return q.ToList();
        }
        /// <summary>
        /// 添加商品类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool AddGoodsType( GoodsType type)
        {
            _context.GoodsTypes.Add(type);
            return _context.SaveChanges()>0;
        }
        /// <summary>
        /// 删除商品类型
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public bool DelGoodsType(Guid typeId)
        {
            var model = _context.GoodsTypes.FirstOrDefault(x => x.Id == typeId);
            model.IsDelete = true;
            return _context.SaveChanges()>0;
        }
        /// <summary>
        /// 根据类型Id获取品牌
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public List<GoodsBrand> GetBrandList(Guid typeId)
        {
            var q = from a in _context.BrandOfGoodsTypes
                    join b in _context.GoodsBrands on a.BandsId equals b.Id
                    where a.TypeId == typeId
                    select b;
            return q.ToList();
        }

        public List<GoodsBrand> GetAllBrand(Guid userId)
        {
            var q = _context.GoodsBrands.Where(x=>!x.IsDelete&&x.CreateUserId == userId).ToList();
            return q;
        }

        public bool AddGoodsBrand(GoodsBrand brand)
        {
            _context.GoodsBrands.Add(brand);
            return _context.SaveChanges() > 0;
        }

        public GoodsType GetTypeById(Guid typeId)
        {
            var q = _context.GoodsTypes.FirstOrDefault(x => x.Id == typeId);
            return q;
        }

        public bool SaveBrandOfType(Guid typeId,List<Guid> brandList)
        {
            var typeList = GetBrandList(typeId);
            foreach(var item in typeList)
            {
                if(!brandList.Contains(item.Id))
                {
                    var model = _context.BrandOfGoodsTypes.FirstOrDefault(x => x.TypeId == typeId && x.BandsId == item.Id);
                    _context.BrandOfGoodsTypes.Remove(model);
                }
            }

            foreach(var item in brandList)
            {
                if(!typeList.Exists(x=>x.Id == item))
                {
                    var model = new BrandOfGoodsType();
                    model.TypeId = typeId;
                    model.BandsId = item;
                    _context.BrandOfGoodsTypes.Add(model);
                }
            }
            return _context.SaveChanges() > 0;
        }

        public bool SaveGoodsInfo(GoodInfo good)
        {
            _context.GoodInfoes.Add(good);
            return _context.SaveChanges() > 0;
        }
        public bool SavePrice(List<PriceOfUserType> priceList)
        {
            _context.PriceOfUserTypes.AddRange(priceList);
            return _context.SaveChanges() > 0;
        }

    }
}
