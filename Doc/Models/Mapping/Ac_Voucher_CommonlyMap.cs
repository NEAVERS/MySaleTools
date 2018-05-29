using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_CommonlyMap : EntityTypeConfiguration<Ac_Voucher_Commonly>
    {
        public Ac_Voucher_CommonlyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillCode, t.BillName, t.STypeId, t.BillNumberId });

            // Properties
            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.BillName)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.FYear)
                .HasMaxLength(10);

            this.Property(t => t.FComment)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Commonly");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillName).HasColumnName("BillName");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.VgId).HasColumnName("VgId");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.AttachFileCount).HasColumnName("AttachFileCount");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.FDebitTotal).HasColumnName("FDebitTotal");
            this.Property(t => t.FCreditTotal).HasColumnName("FCreditTotal");
            this.Property(t => t.FEntryCount).HasColumnName("FEntryCount");
            this.Property(t => t.FModifyTime).HasColumnName("FModifyTime");
            this.Property(t => t.FComment).HasColumnName("FComment");
        }
    }
}
