using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_Generate_Voucherbill_GoodsBillsMap : EntityTypeConfiguration<Ac_Voucher_Generate_Voucherbill_GoodsBills>
    {
        public Ac_Voucher_Generate_Voucherbill_GoodsBillsMap()
        {
            // Primary Key
            this.HasKey(t => t.STypeId);

            // Properties
            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Generate_Voucherbill_GoodsBills");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.billnumberids).HasColumnName("billnumberids");
        }
    }
}
