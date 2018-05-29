using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommissionRuleLeaderMap : EntityTypeConfiguration<CommissionRuleLeader>
    {
        public CommissionRuleLeaderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.CommissionTypeID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CommissionTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EtypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommissionRuleLeader");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CommissionTypeID).HasColumnName("CommissionTypeID");
            this.Property(t => t.MinRegion).HasColumnName("MinRegion");
            this.Property(t => t.MaxRegion).HasColumnName("MaxRegion");
            this.Property(t => t.Proportion).HasColumnName("Proportion");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
        }
    }
}
