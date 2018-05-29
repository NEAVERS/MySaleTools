using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SaleTimeTotalMap : EntityTypeConfiguration<SaleTimeTotal>
    {
        public SaleTimeTotalMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FullName)
                .HasMaxLength(400);

            this.Property(t => t.Years)
                .HasMaxLength(10);

            this.Property(t => t.Comment)
                .HasMaxLength(800);

            // Table & Column Mappings
            this.ToTable("SaleTimeTotal");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Years).HasColumnName("Years");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.IfUse).HasColumnName("IfUse");
        }
    }
}
