using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PromoRule_Detail_BtypeConfigMap : EntityTypeConfiguration<PromoRule_Detail_BtypeConfig>
    {
        public PromoRule_Detail_BtypeConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PromoRuleID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PromoRuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PromoRule_Detail_BtypeConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PromoRuleID).HasColumnName("PromoRuleID");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
        }
    }
}
