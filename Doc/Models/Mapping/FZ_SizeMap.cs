using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FZ_SizeMap : EntityTypeConfiguration<FZ_Size>
    {
        public FZ_SizeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SizeID, t.SizeName, t.Del });

            // Properties
            this.Property(t => t.SizeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SizeName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FZ_Size");
            this.Property(t => t.SizeID).HasColumnName("SizeID");
            this.Property(t => t.SizeName).HasColumnName("SizeName");
            this.Property(t => t.Del).HasColumnName("Del");
        }
    }
}
