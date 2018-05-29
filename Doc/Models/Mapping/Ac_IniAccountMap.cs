using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_IniAccountMap : EntityTypeConfiguration<Ac_IniAccount>
    {
        public Ac_IniAccountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.STypeId, t.ATypeId });

            // Properties
            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FYear)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Ac_IniAccount");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.iniYTotal).HasColumnName("iniYTotal");
            this.Property(t => t.iniYTotalFor).HasColumnName("iniYTotalFor");
            this.Property(t => t.FDebit).HasColumnName("FDebit");
            this.Property(t => t.FDebitFor).HasColumnName("FDebitFor");
            this.Property(t => t.FCredit).HasColumnName("FCredit");
            this.Property(t => t.FCreditFor).HasColumnName("FCreditFor");
            this.Property(t => t.iniTotal).HasColumnName("iniTotal");
            this.Property(t => t.iniTotalFor).HasColumnName("iniTotalFor");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.FYTotal).HasColumnName("FYTotal");
            this.Property(t => t.FYTotalFor).HasColumnName("FYTotalFor");
            this.Property(t => t.FYTotalDebit).HasColumnName("FYTotalDebit");
            this.Property(t => t.FYTotalDebitFor).HasColumnName("FYTotalDebitFor");
            this.Property(t => t.FYTotalCredit).HasColumnName("FYTotalCredit");
            this.Property(t => t.FYTotalCreditFor).HasColumnName("FYTotalCreditFor");
        }
    }
}
