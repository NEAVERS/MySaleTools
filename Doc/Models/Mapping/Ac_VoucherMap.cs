using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_VoucherMap : EntityTypeConfiguration<Ac_Voucher>
    {
        public Ac_VoucherMap()
        {
            // Primary Key
            this.HasKey(t => new { t.STypeId, t.BillNumberId, t.ReCheckId, t.IfCheck });

            // Properties
            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .HasMaxLength(400);

            this.Property(t => t.TallyId)
                .HasMaxLength(50);

            this.Property(t => t.AuditId)
                .HasMaxLength(50);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.FYear)
                .HasMaxLength(10);

            this.Property(t => t.MarkError)
                .HasMaxLength(200);

            this.Property(t => t.FComment)
                .HasMaxLength(400);

            this.Property(t => t.FFootNote)
                .HasMaxLength(400);

            this.Property(t => t.Teller)
                .HasMaxLength(50);

            this.Property(t => t.ReCheckId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IfCheck)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.VgId).HasColumnName("VgId");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.FlowNo).HasColumnName("FlowNo");
            this.Property(t => t.AttachFileCount).HasColumnName("AttachFileCount");
            this.Property(t => t.TallyId).HasColumnName("TallyId");
            this.Property(t => t.FChecked).HasColumnName("FChecked");
            this.Property(t => t.AuditId).HasColumnName("AuditId");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.MarkError).HasColumnName("MarkError");
            this.Property(t => t.FCreditTotal).HasColumnName("FCreditTotal");
            this.Property(t => t.FDebitTotal).HasColumnName("FDebitTotal");
            this.Property(t => t.FEntryCount).HasColumnName("FEntryCount");
            this.Property(t => t.FModifyTime).HasColumnName("FModifyTime");
            this.Property(t => t.FComment).HasColumnName("FComment");
            this.Property(t => t.FFootNote).HasColumnName("FFootNote");
            this.Property(t => t.Audited).HasColumnName("Audited");
            this.Property(t => t.FSerialNum).HasColumnName("FSerialNum");
            this.Property(t => t.Teller).HasColumnName("Teller");
            this.Property(t => t.IsSelect).HasColumnName("IsSelect");
            this.Property(t => t.ReCheckId).HasColumnName("ReCheckId");
            this.Property(t => t.IfCheck).HasColumnName("IfCheck");
            this.Property(t => t.posttime).HasColumnName("posttime");
            this.Property(t => t.RedWord).HasColumnName("RedWord");
            this.Property(t => t.VoucherType).HasColumnName("VoucherType");
            this.Property(t => t.IsCommission).HasColumnName("IsCommission");
        }
    }
}
