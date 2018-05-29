using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_CommissionBill_VoucherBillMap : EntityTypeConfiguration<Ac_CommissionBill_VoucherBill>
    {
        public Ac_CommissionBill_VoucherBillMap()
        {
            // Primary Key
            this.HasKey(t => t.Agvbid);

            // Properties
            // Table & Column Mappings
            this.ToTable("Ac_CommissionBill_VoucherBill");
            this.Property(t => t.Agvbid).HasColumnName("Agvbid");
            this.Property(t => t.GoodsBillId).HasColumnName("GoodsBillId");
            this.Property(t => t.VourchBillId).HasColumnName("VourchBillId");
        }
    }
}
