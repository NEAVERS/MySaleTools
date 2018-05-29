using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class StockCheckMap : EntityTypeConfiguration<StockCheck>
    {
        public StockCheckMap()
        {
            // Primary Key
            this.HasKey(t => new { t.StockCheckID, t.Id });

            // Properties
            this.Property(t => t.StockCheckID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            this.Property(t => t.GoodsBTypeID)
                .HasMaxLength(50);

            this.Property(t => t.CargoSpace)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("StockCheck");
            this.Property(t => t.StockCheckID).HasColumnName("StockCheckID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsBTypeID).HasColumnName("GoodsBTypeID");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
            this.Property(t => t.GoodsCostTotal).HasColumnName("GoodsCostTotal");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
            this.Property(t => t.StockQty).HasColumnName("StockQty");
            this.Property(t => t.CargoSpace).HasColumnName("CargoSpace");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.nqty).HasColumnName("nqty");
            this.Property(t => t.stocknqty).HasColumnName("stocknqty");
        }
    }
}
