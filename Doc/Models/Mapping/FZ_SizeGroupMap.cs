using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class FZ_SizeGroupMap : EntityTypeConfiguration<FZ_SizeGroup>
    {
        public FZ_SizeGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SizeGroupID, t.SizeGroupName, t.Del });

            // Properties
            this.Property(t => t.SizeGroupID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SizeGroupName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Comment)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("FZ_SizeGroup");
            this.Property(t => t.SizeGroupID).HasColumnName("SizeGroupID");
            this.Property(t => t.SizeGroupName).HasColumnName("SizeGroupName");
            this.Property(t => t.Del).HasColumnName("Del");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
