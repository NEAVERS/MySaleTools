using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_BalanceTypeMap : EntityTypeConfiguration<Ac_BalanceType>
    {
        public Ac_BalanceTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BtId, t.UserCode, t.FullName });

            // Properties
            this.Property(t => t.BtId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_BalanceType");
            this.Property(t => t.BtId).HasColumnName("BtId");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
        }
    }
}
