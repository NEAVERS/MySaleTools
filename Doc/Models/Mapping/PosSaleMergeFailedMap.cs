using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosSaleMergeFailedMap : EntityTypeConfiguration<PosSaleMergeFailed>
    {
        public PosSaleMergeFailedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.PosBillNumberId });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PosBillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Reason)
                .HasMaxLength(500);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PosSaleMergeFailed");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PosBillNumberId).HasColumnName("PosBillNumberId");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
