using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Voucher_Bill_Assist_CheckItemsMap : EntityTypeConfiguration<Ac_Voucher_Bill_Assist_CheckItems>
    {
        public Ac_Voucher_Bill_Assist_CheckItemsMap()
        {
            // Primary Key
            this.HasKey(t => t.nId);

            // Properties
            this.Property(t => t.typeName)
                .HasMaxLength(10);

            this.Property(t => t.TypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_Voucher_Bill_Assist_CheckItems");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.vBId).HasColumnName("vBId");
            this.Property(t => t.typeName).HasColumnName("typeName");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
        }
    }
}
