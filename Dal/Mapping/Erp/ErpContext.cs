using Model.Erp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping.Erp
{
    public class ErpContext : DbContext
    {
        public ErpContext() : base(ConfigurationManager.ConnectionStrings["Erp"].ToString())
        {
        }


        public DbSet<ptype> ptypes { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<GoodsStocks> GoodsStockses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ptypeMap());
            modelBuilder.Configurations.Add(new StockMap());
            modelBuilder.Configurations.Add(new GoodsStocksMap());
     }


    }
}
