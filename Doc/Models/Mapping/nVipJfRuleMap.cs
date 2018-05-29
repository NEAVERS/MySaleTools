using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class nVipJfRuleMap : EntityTypeConfiguration<nVipJfRule>
    {
        public nVipJfRuleMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Explain)
                .HasMaxLength(1024);

            // Table & Column Mappings
            this.ToTable("nVipJfRule");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Explain).HasColumnName("Explain");
        }
    }
}
