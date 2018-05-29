using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FZ_ColorMap : EntityTypeConfiguration<FZ_Color>
    {
        public FZ_ColorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ColorID, t.ColorName, t.Del });

            // Properties
            this.Property(t => t.ColorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ColorName)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FZ_Color");
            this.Property(t => t.ColorID).HasColumnName("ColorID");
            this.Property(t => t.ColorName).HasColumnName("ColorName");
            this.Property(t => t.Del).HasColumnName("Del");
        }
    }
}
