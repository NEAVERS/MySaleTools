using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_Repair_MsgMap : EntityTypeConfiguration<Ac_Voucher_Repair_Msg>
    {
        public Ac_Voucher_Repair_MsgMap()
        {
            // Primary Key
            this.HasKey(t => t.nid);

            // Properties
            this.Property(t => t.Msg)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Repair_Msg");
            this.Property(t => t.nid).HasColumnName("nid");
            this.Property(t => t.Msg).HasColumnName("Msg");
        }
    }
}
