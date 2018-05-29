using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CustomFieldDataMap : EntityTypeConfiguration<CustomFieldData>
    {
        public CustomFieldDataMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.configKind)
                .HasMaxLength(50);

            this.Property(t => t.userId)
                .HasMaxLength(50);

            this.Property(t => t.elementId)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CustomFieldData");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.configKind).HasColumnName("configKind");
            this.Property(t => t.profile).HasColumnName("profile");
            this.Property(t => t.userId).HasColumnName("userId");
            this.Property(t => t.elementId).HasColumnName("elementId");
            this.Property(t => t.content).HasColumnName("content");
        }
    }
}
