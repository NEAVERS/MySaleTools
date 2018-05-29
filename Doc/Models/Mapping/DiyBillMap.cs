using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DiyBillMap : EntityTypeConfiguration<DiyBill>
    {
        public DiyBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.PtypeId, t.typeId });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.typeId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DiyBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.SaleTotal).HasColumnName("SaleTotal");
            this.Property(t => t.typeId).HasColumnName("typeId");
        }
    }
}
