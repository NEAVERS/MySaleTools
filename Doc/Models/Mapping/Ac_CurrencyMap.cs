using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_CurrencyMap : EntityTypeConfiguration<Ac_Currency>
    {
        public Ac_CurrencyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CId, t.UserCode, t.FullName, t.Sysrow });

            // Properties
            this.Property(t => t.CId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PyCode)
                .HasMaxLength(200);

            this.Property(t => t.Sysrow)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ac_Currency");
            this.Property(t => t.CId).HasColumnName("CId");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.BasisType).HasColumnName("BasisType");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.Sysrow).HasColumnName("Sysrow");
        }
    }
}
