using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosGoodsStocksDetailViewMap : EntityTypeConfiguration<PosGoodsStocksDetailView>
    {
        public PosGoodsStocksDetailViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.colorid, t.sizeid, t.Price, t.iBYZD, t.nBYZD });

            // Properties
            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.Ktypeid)
                .HasMaxLength(50);

            this.Property(t => t.colorid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sizeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cBYZD)
                .HasMaxLength(30);

            this.Property(t => t.iBYZD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nBYZD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosGoodsStocksDetailView");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.Ktypeid).HasColumnName("Ktypeid");
            this.Property(t => t.colorid).HasColumnName("colorid");
            this.Property(t => t.sizeid).HasColumnName("sizeid");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.cBYZD).HasColumnName("cBYZD");
            this.Property(t => t.iBYZD).HasColumnName("iBYZD");
            this.Property(t => t.nBYZD).HasColumnName("nBYZD");
        }
    }
}
