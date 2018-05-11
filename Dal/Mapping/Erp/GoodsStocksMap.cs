using Model.Erp;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Mapping.Erp
{
    public class GoodsStocksMap : EntityTypeConfiguration<GoodsStocks>
    {
        public GoodsStocksMap()
        {
            this.ToTable("GoodsStocks");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.JobNumber).HasColumnName("JobNumber");
            this.Property(t => t.KtypeId).HasColumnName("KtypeId");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsBTypeID).HasColumnName("GoodsBTypeID");

        }
    }
}
