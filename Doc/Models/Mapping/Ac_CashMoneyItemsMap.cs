using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_CashMoneyItemsMap : EntityTypeConfiguration<Ac_CashMoneyItems>
    {
        public Ac_CashMoneyItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TypeId, t.ParId, t.Leveal, t.SonNum, t.SonCount, t.UserCode, t.FullName, t.Sysrow });

            // Properties
            this.Property(t => t.TypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ParId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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
            this.ToTable("Ac_CashMoneyItems");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.ParId).HasColumnName("ParId");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.Sysrow).HasColumnName("Sysrow");
        }
    }
}
