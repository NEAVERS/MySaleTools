using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Custom_ColumnMap : EntityTypeConfiguration<Custom_Column>
    {
        public Custom_ColumnMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.ColumnName)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Custom_Column");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.ColumnName).HasColumnName("ColumnName");
            this.Property(t => t.ColumnType).HasColumnName("ColumnType");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
