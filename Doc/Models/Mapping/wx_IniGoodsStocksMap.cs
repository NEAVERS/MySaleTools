using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class wx_IniGoodsStocksMap : EntityTypeConfiguration<wx_IniGoodsStocks>
    {
        public wx_IniGoodsStocksMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PTypeId, t.KTypeId });

            // Properties
            this.Property(t => t.PTypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KTypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.JobNumber)
                .HasMaxLength(20);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            this.Property(t => t.GoodsBTypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("wx_IniGoodsStocks");
            this.Property(t => t.PTypeId).HasColumnName("PTypeId");
            this.Property(t => t.KTypeId).HasColumnName("KTypeId");
            this.Property(t => t.JobNumber).HasColumnName("JobNumber");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsBTypeID).HasColumnName("GoodsBTypeID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Iscombined).HasColumnName("Iscombined");
            this.Property(t => t.Nqty).HasColumnName("Nqty");
        }
    }
}
