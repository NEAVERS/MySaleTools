using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BATypeIdPresetMap : EntityTypeConfiguration<BATypeIdPreset>
    {
        public BATypeIdPresetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BTypeName)
                .HasMaxLength(100);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BATypeIdPreset");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BTypeName).HasColumnName("BTypeName");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.SubId).HasColumnName("SubId");
        }
    }
}
