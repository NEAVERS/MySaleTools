using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PromoRule_Detail_KConfigMap : EntityTypeConfiguration<PromoRule_Detail_KConfig>
    {
        public PromoRule_Detail_KConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PromoRuleID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PromoRuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ktypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PromoRule_Detail_KConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PromoRuleID).HasColumnName("PromoRuleID");
            this.Property(t => t.Ktypeid).HasColumnName("Ktypeid");
        }
    }
}
