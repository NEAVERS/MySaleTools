using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_BankStatementDetailMap : EntityTypeConfiguration<Te_BankStatementDetail>
    {
        public Te_BankStatementDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.TellerName, t.Summary });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BusinessId)
                .HasMaxLength(50);

            this.Property(t => t.TellerName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FSettleNo)
                .HasMaxLength(50);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.Summary)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Te_BankStatementDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Businessdate).HasColumnName("Businessdate");
            this.Property(t => t.BusinessId).HasColumnName("BusinessId");
            this.Property(t => t.TellerName).HasColumnName("TellerName");
            this.Property(t => t.FSettleId).HasColumnName("FSettleId");
            this.Property(t => t.FSettleNo).HasColumnName("FSettleNo");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.FDebit).HasColumnName("FDebit");
            this.Property(t => t.FCredit).HasColumnName("FCredit");
            this.Property(t => t.FEndBalance).HasColumnName("FEndBalance");
            this.Property(t => t.SourceId).HasColumnName("SourceId");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.FDC).HasColumnName("FDC");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.IsInit).HasColumnName("IsInit");
        }
    }
}
