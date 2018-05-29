using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosGoodsStocksViewMap : EntityTypeConfiguration<PosGoodsStocksView>
    {
        public PosGoodsStocksViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderID, t.RowOrder, t.iBYZD, t.nBYZD });

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .HasMaxLength(50);

            this.Property(t => t.RowOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cBYZD)
                .HasMaxLength(30);

            this.Property(t => t.iBYZD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nBYZD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosGoodsStocksView");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
            this.Property(t => t.RowOrder).HasColumnName("RowOrder");
            this.Property(t => t.cBYZD).HasColumnName("cBYZD");
            this.Property(t => t.iBYZD).HasColumnName("iBYZD");
            this.Property(t => t.nBYZD).HasColumnName("nBYZD");
        }
    }
}
