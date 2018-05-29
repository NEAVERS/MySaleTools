using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_Journal_DetailMap : EntityTypeConfiguration<Te_Journal_Detail>
    {
        public Te_Journal_DetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Summary });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.Summary)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            this.Property(t => t.FSettleNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Te_Journal_Detail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BusinessDate).HasColumnName("BusinessDate");
            this.Property(t => t.SourceId).HasColumnName("SourceId");
            this.Property(t => t.VoucherId).HasColumnName("VoucherId");
            this.Property(t => t.GoodsBillNumberId).HasColumnName("GoodsBillNumberId");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.FDebit).HasColumnName("FDebit");
            this.Property(t => t.FCredit).HasColumnName("FCredit");
            this.Property(t => t.FEndBalance).HasColumnName("FEndBalance");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.IsCash).HasColumnName("IsCash");
            this.Property(t => t.FDC).HasColumnName("FDC");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.FSettleId).HasColumnName("FSettleId");
            this.Property(t => t.FSettleNo).HasColumnName("FSettleNo");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.FDebitOri).HasColumnName("FDebitOri");
            this.Property(t => t.FCreditOri).HasColumnName("FCreditOri");
            this.Property(t => t.FEndBalanceOri).HasColumnName("FEndBalanceOri");
            this.Property(t => t.IsInit).HasColumnName("IsInit");
        }
    }
}
