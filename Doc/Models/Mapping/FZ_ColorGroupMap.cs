using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FZ_ColorGroupMap : EntityTypeConfiguration<FZ_ColorGroup>
    {
        public FZ_ColorGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ColorGroupID, t.ColorGroupName, t.Del });

            // Properties
            this.Property(t => t.ColorGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ColorGroupName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Comment)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("FZ_ColorGroup");
            this.Property(t => t.ColorGroupID).HasColumnName("ColorGroupID");
            this.Property(t => t.ColorGroupName).HasColumnName("ColorGroupName");
            this.Property(t => t.Del).HasColumnName("Del");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
