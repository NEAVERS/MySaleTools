using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_GroupMap : EntityTypeConfiguration<Ac_Voucher_Group>
    {
        public Ac_Voucher_GroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VgId, t.FullName, t.IsDefault });

            // Properties
            this.Property(t => t.VgId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PyCode)
                .HasMaxLength(200);

            this.Property(t => t.IsDefault)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Group");
            this.Property(t => t.VgId).HasColumnName("VgId");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.IsMulVourchLimit).HasColumnName("IsMulVourchLimit");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
        }
    }
}
