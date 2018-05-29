using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class GuestBackMap : EntityTypeConfiguration<GuestBack>
    {
        public GuestBackMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.jobnumber)
                .HasMaxLength(20);

            this.Property(t => t.comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("GuestBack");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.discount).HasColumnName("discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.jobnumber).HasColumnName("jobnumber");
            this.Property(t => t.goodsno).HasColumnName("goodsno");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TeamNO1).HasColumnName("TeamNO1");
        }
    }
}
