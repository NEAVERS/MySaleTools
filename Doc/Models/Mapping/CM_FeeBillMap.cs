using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CM_FeeBillMap : EntityTypeConfiguration<CM_FeeBill>
    {
        public CM_FeeBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.FeetypeId });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.FeetypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CM_FeeBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.FeetypeId).HasColumnName("FeetypeId");
            this.Property(t => t.Total).HasColumnName("Total");
        }
    }
}
