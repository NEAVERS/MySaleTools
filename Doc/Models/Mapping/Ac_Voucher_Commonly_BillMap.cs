using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_Commonly_BillMap : EntityTypeConfiguration<Ac_Voucher_Commonly_Bill>
    {
        public Ac_Voucher_Commonly_BillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Summary, t.STypeId, t.ATypeId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Summary)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FYear)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.AscIds)
                .HasMaxLength(4000);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Commonly_Bill");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.Fdc).HasColumnName("Fdc");
            this.Property(t => t.FAdc).HasColumnName("FAdc");
            this.Property(t => t.FDebitTotal).HasColumnName("FDebitTotal");
            this.Property(t => t.FCreditTotal).HasColumnName("FCreditTotal");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.RowNo).HasColumnName("RowNo");
            this.Property(t => t.AscIds).HasColumnName("AscIds");
        }
    }
}
