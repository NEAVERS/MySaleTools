using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FZ_SizeMatchingMap : EntityTypeConfiguration<FZ_SizeMatching>
    {
        public FZ_SizeMatchingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SizeID, t.SizeGroupID });

            // Properties
            this.Property(t => t.SizeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SizeGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FZ_SizeMatching");
            this.Property(t => t.SizeID).HasColumnName("SizeID");
            this.Property(t => t.SizeGroupID).HasColumnName("SizeGroupID");
        }
    }
}
