using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_BalanceMap : EntityTypeConfiguration<Te_Balance>
    {
        public Te_BalanceMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Te_Balance");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.BUId).HasColumnName("BUId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.InitBalance).HasColumnName("InitBalance");
            this.Property(t => t.InitBalanceFor).HasColumnName("InitBalanceFor");
            this.Property(t => t.InitYearBalance).HasColumnName("InitYearBalance");
            this.Property(t => t.InitYearBalanceFor).HasColumnName("InitYearBalanceFor");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.FDebit).HasColumnName("FDebit");
            this.Property(t => t.FDebitFor).HasColumnName("FDebitFor");
            this.Property(t => t.FCredit).HasColumnName("FCredit");
            this.Property(t => t.FCreditFor).HasColumnName("FCreditFor");
            this.Property(t => t.FEndBalance).HasColumnName("FEndBalance");
            this.Property(t => t.FEndBalanceFor).HasColumnName("FEndBalanceFor");
            this.Property(t => t.FYtdDebit).HasColumnName("FYtdDebit");
            this.Property(t => t.FYtdDebitFor).HasColumnName("FYtdDebitFor");
            this.Property(t => t.FYtdCredit).HasColumnName("FYtdCredit");
            this.Property(t => t.FYtdCreditFor).HasColumnName("FYtdCreditFor");
        }
    }
}
