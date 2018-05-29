using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Custom_DisplayColumnMap : EntityTypeConfiguration<Custom_DisplayColumn>
    {
        public Custom_DisplayColumnMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DataField)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(200);

            this.Property(t => t.BaseInfo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Custom_DisplayColumn");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.DataField).HasColumnName("DataField");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.BaseInfo).HasColumnName("BaseInfo");
        }
    }
}
