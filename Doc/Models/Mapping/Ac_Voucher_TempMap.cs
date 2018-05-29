using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_TempMap : EntityTypeConfiguration<Ac_Voucher_Temp>
    {
        public Ac_Voucher_TempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.STypeId, t.BillNumberId });

            // Properties
            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FComment)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Temp");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.VgId).HasColumnName("VgId");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.FlowNo).HasColumnName("FlowNo");
            this.Property(t => t.FComment).HasColumnName("FComment");
            this.Property(t => t.SbillType).HasColumnName("SbillType");
            this.Property(t => t.InOutType).HasColumnName("InOutType");
        }
    }
}
