using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_BillMap : EntityTypeConfiguration<Ac_Voucher_Bill>
    {
        public Ac_Voucher_BillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Summary, t.STypeId, t.ATypeId, t.ID });

            // Properties
            this.Property(t => t.Summary)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ATypeId2)
                .HasMaxLength(50);

            this.Property(t => t.F_ExchId)
                .HasMaxLength(50);

            this.Property(t => t.F_ExchIdFor)
                .HasMaxLength(50);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.AscIds)
                .HasMaxLength(4000);

            this.Property(t => t.FSettleNo)
                .HasMaxLength(200);

            this.Property(t => t.FYear)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Bill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.ATypeId2).HasColumnName("ATypeId2");
            this.Property(t => t.Fdc).HasColumnName("Fdc");
            this.Property(t => t.F_ExchId).HasColumnName("F_ExchId");
            this.Property(t => t.F_ExchIdFor).HasColumnName("F_ExchIdFor");
            this.Property(t => t.FDebitTotal).HasColumnName("FDebitTotal");
            this.Property(t => t.FDebitTotalFor).HasColumnName("FDebitTotalFor");
            this.Property(t => t.FCreditTotal).HasColumnName("FCreditTotal");
            this.Property(t => t.FCreditTotalFor).HasColumnName("FCreditTotalFor");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OldID).HasColumnName("OldID");
            this.Property(t => t.FCashFlowItem).HasColumnName("FCashFlowItem");
            this.Property(t => t.AscIds).HasColumnName("AscIds");
            this.Property(t => t.FSettleNo).HasColumnName("FSettleNo");
            this.Property(t => t.FSettleTypeID).HasColumnName("FSettleTypeID");
            this.Property(t => t.FSettleDate).HasColumnName("FSettleDate");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.RowNo).HasColumnName("RowNo");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.FAdc).HasColumnName("FAdc");
        }
    }
}
