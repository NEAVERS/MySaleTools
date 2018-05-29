using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Custom_DisplayColumnOrderMap : EntityTypeConfiguration<Custom_DisplayColumnOrder>
    {
        public Custom_DisplayColumnOrderMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.OrderName)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Custom_DisplayColumnOrder");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.OrderName).HasColumnName("OrderName");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
