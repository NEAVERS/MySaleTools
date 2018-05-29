using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ini_GOODSSTOCKS_QTYMap : EntityTypeConfiguration<Ini_GOODSSTOCKS_QTY>
    {
        public Ini_GOODSSTOCKS_QTYMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ini_GOODSSTOCKS_QTY");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.Iscombined).HasColumnName("Iscombined");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
        }
    }
}
