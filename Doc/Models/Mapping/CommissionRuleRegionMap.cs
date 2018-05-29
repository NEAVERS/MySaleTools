using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommissionRuleRegionMap : EntityTypeConfiguration<CommissionRuleRegion>
    {
        public CommissionRuleRegionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.EtypeID, t.PtypeID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PtypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommissionRuleRegion");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.MinRegion).HasColumnName("MinRegion");
            this.Property(t => t.MaxRegion).HasColumnName("MaxRegion");
            this.Property(t => t.Proportion).HasColumnName("Proportion");
        }
    }
}
