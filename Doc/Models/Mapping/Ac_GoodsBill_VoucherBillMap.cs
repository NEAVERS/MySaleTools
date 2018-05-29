using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_GoodsBill_VoucherBillMap : EntityTypeConfiguration<Ac_GoodsBill_VoucherBill>
    {
        public Ac_GoodsBill_VoucherBillMap()
        {
            // Primary Key
            this.HasKey(t => t.Agvbid);

            // Properties
            // Table & Column Mappings
            this.ToTable("Ac_GoodsBill_VoucherBill");
            this.Property(t => t.Agvbid).HasColumnName("Agvbid");
            this.Property(t => t.GoodsBillId).HasColumnName("GoodsBillId");
            this.Property(t => t.VourchBillId).HasColumnName("VourchBillId");
            this.Property(t => t.AtId).HasColumnName("AtId");
            this.Property(t => t.InOutType).HasColumnName("InOutType");
        }
    }
}
