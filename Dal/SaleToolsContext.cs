using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Mapping;
using System.Configuration;

namespace Dal
{
    public class SaleToolsContext : DbContext
    {
        public SaleToolsContext() : base(ConfigurationManager.ConnectionStrings["SaleTools"].ToString())
        {
        }

        public DbSet<UserInfo> UserInfoes { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<GoodsBrand> GoodsBrands { get; set; }

        public DbSet<BrandOfGoodsType> BrandOfGoodsTypes { get; set; }

        public DbSet<GoodsType> GoodsTypes { get; set; }

        public DbSet<GoodInfo> GoodInfoes { get; set; }

        public DbSet<PriceOfUserType> PriceOfUserTypes { get; set; }

        public DbSet<OrderInfo> OrderInfoes { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserInfoMap());
            modelBuilder.Configurations.Add(new UserTypeMap());
            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new GoodsBrandMap());
            modelBuilder.Configurations.Add(new BrandOfGoodsTypeMap());
            modelBuilder.Configurations.Add(new GoodsTypeMap());
            modelBuilder.Configurations.Add(new GoodInfoMap()); 
            modelBuilder.Configurations.Add(new PriceOfUserTypeMap());
            modelBuilder.Configurations.Add(new OrderInfoMap());
            modelBuilder.Configurations.Add(new OrderItemMap());
        }
    }
}
