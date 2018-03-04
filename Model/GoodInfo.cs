using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GoodInfo
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        public string GoodsNum { get; set; }
        /// <summary>
        /// 商品条形码
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// 商品中码
        /// </summary>
        public string MiddleCode { get; set; }
        /// <summary>
        /// 商品箱码
        /// </summary>
        public string BoxCode { get; set; }
        /// <summary>
        /// 供应商Id
        /// </summary>
        public int SupplierId { get; set; }
        /// <summary>
        /// 供应商编号
        /// </summary>
        public string SupplierNum { get; set; }
        /// <summary>
        /// 供应商姓名
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 一级分类Id
        /// </summary>
        public Guid FirstTypeId { get; set; }
        /// <summary>
        /// 一级分类名
        /// </summary>
        public string FirstTypeName { get; set; }
        /// <summary>
        /// 二级分类Id
        /// </summary>
        public Guid SecondTypeId { get; set; }
        /// <summary>
        /// 二级分类名
        /// </summary>
        public string SecondTypeName { get; set; }
        /// <summary>
        /// 三级分类Id
        /// </summary>
        public Guid ThirdTYypeId { get; set; }
        /// <summary>
        /// 三级分类名
        /// </summary>
        public string ThirdTypeName { get; set; }
        /// <summary>
        /// 商品标题
        /// </summary>
        public string GoodsTittle { get; set; }
        /// <summary>
        /// 商品副标题
        /// </summary>
        public string GoodsSubTittle { get; set; }
        /// <summary>
        /// 商品品牌Id
        /// </summary>
        public Guid BrandId { get; set; }
        /// <summary>
        /// 商品品牌名
        /// </summary>
        public string BrandName { get; set; }
        /// <summary>
        /// 建议零售价
        /// </summary>
        public decimal RetailtPrice { get; set; }
        /// <summary>
        /// 参考价
        /// </summary>
        public decimal MarketPrice { get; set; }
        /// <summary>
        /// 成本价
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// 商品库存
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// 锁定库存
        /// </summary>
        public bool IsLockStork { get; set; }
        /// <summary>
        /// 整箱规格信息
        /// </summary>
        public string BoxSpec { get; set; }
        /// <summary>
        /// 商品规格信息
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 商品重量
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// 商品体积
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        /// 商品保质期
        /// </summary>
        public int ShelfLife { get; set; }
        /// <summary>
        /// 最小起批数
        /// </summary>
        public int MinCount { get; set; }
        /// <summary>
        /// 限购数量
        /// </summary>
        public int LimitCount { get; set; }
        public string pic1 { get; set; }
        public string pic2 { get; set; }
        public string pic3 { get; set; }
        public string pic4 { get; set; }
        public string pic5 { get; set; }
        /// <summary>
        /// 关键字
        /// </summary>
        public string KeyWord { get; set; }
        /// <summary>
        /// 商品详情
        /// </summary>
        public string Detail { get; set; }

        public Guid CreateUserId { get; set; }

        public string CreateUserName { get; set; }

        public bool IsDelete { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int SortId { get; set; }

        public bool IsUpShelves { get; set; }


        public GoodInfo()
        {
            IsUpShelves = false;
            SortId = 0;
        }

    }
}
