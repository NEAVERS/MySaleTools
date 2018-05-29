using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceRule_Detail_KConfigMap : EntityTypeConfiguration<PriceRule_Detail_KConfig>
    {
        public PriceRule_Detail_KConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Ktypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceRule_Detail_KConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PriceRuleID).HasColumnName("PriceRuleID");
            this.Property(t => t.Ktypeid).HasColumnName("Ktypeid");
        }
    }
}
