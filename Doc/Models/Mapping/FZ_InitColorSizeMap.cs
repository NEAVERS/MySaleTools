using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FZ_InitColorSizeMap : EntityTypeConfiguration<FZ_InitColorSize>
    {
        public FZ_InitColorSizeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ColorID, t.SizeID });

            // Properties
            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.KtypeID)
                .HasMaxLength(50);

            this.Property(t => t.ColorID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SizeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FZ_InitColorSize");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.ColorID).HasColumnName("ColorID");
            this.Property(t => t.SizeID).HasColumnName("SizeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
        }
    }
}
