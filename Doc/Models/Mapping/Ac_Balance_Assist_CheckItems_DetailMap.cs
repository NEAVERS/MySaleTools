using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Balance_Assist_CheckItems_DetailMap : EntityTypeConfiguration<Ac_Balance_Assist_CheckItems_Detail>
    {
        public Ac_Balance_Assist_CheckItems_DetailMap()
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

            this.Property(t => t.FieldValue)
                .HasMaxLength(50);

            this.Property(t => t.FYear)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Ac_Balance_Assist_CheckItems_Detail");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Ascids).HasColumnName("Ascids");
            this.Property(t => t.FieldValue).HasColumnName("FieldValue");
            this.Property(t => t.FDebit).HasColumnName("FDebit");
            this.Property(t => t.FDebitFor).HasColumnName("FDebitFor");
            this.Property(t => t.FCredit).HasColumnName("FCredit");
            this.Property(t => t.FCreditFor).HasColumnName("FCreditFor");
            this.Property(t => t.IniTotal).HasColumnName("IniTotal");
            this.Property(t => t.IniTotalFor).HasColumnName("IniTotalFor");
            this.Property(t => t.FEndBalance).HasColumnName("FEndBalance");
            this.Property(t => t.FEndBalanceFor).HasColumnName("FEndBalanceFor");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
        }
    }
}
