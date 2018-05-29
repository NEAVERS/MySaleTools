using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Custom_ColumnTypeMap : EntityTypeConfiguration<Custom_ColumnType>
    {
        public Custom_ColumnTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Comment)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Custom_ColumnType");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
