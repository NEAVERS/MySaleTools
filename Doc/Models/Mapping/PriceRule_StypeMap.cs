using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceRule_StypeMap : EntityTypeConfiguration<PriceRule_Stype>
    {
        public PriceRule_StypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PriceRuleID);

            // Properties
            this.Property(t => t.PriceRuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PriceRule_Stype");
            this.Property(t => t.PriceRuleID).HasColumnName("PriceRuleID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
        }
    }
}
