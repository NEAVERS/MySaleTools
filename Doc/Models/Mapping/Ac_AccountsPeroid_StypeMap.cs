using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_AccountsPeroid_StypeMap : EntityTypeConfiguration<Ac_AccountsPeroid_Stype>
    {
        public Ac_AccountsPeroid_StypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_AccountsPeroid_Stype");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
        }
    }
}
