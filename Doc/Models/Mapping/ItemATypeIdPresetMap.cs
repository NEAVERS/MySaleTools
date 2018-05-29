using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ItemATypeIdPresetMap : EntityTypeConfiguration<ItemATypeIdPreset>
    {
        public ItemATypeIdPresetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.ATypeUserCode)
                .HasMaxLength(200);

            this.Property(t => t.ATypeFullName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ItemATypeIdPreset");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ATypeUserCode).HasColumnName("ATypeUserCode");
            this.Property(t => t.ATypeFullName).HasColumnName("ATypeFullName");
            this.Property(t => t.SubId).HasColumnName("SubId");
        }
    }
}
