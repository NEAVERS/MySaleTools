using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DepBillMap : EntityTypeConfiguration<DepBill>
    {
        public DepBillMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Comment)
                .HasMaxLength(255);

            this.Property(t => t.WorkUnit)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("DepBill");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.AssetCardId).HasColumnName("AssetCardId");
            this.Property(t => t.Depreciation).HasColumnName("Depreciation");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.WorkTime).HasColumnName("WorkTime");
            this.Property(t => t.WorkUnit).HasColumnName("WorkUnit");
        }
    }
}
