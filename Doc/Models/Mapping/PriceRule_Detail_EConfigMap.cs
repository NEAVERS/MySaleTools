using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceRule_Detail_EConfigMap : EntityTypeConfiguration<PriceRule_Detail_EConfig>
    {
        public PriceRule_Detail_EConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PriceRuleID, t.Etypeid });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PriceRuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Etypeid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceRule_Detail_EConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PriceRuleID).HasColumnName("PriceRuleID");
            this.Property(t => t.Etypeid).HasColumnName("Etypeid");
        }
    }
}
