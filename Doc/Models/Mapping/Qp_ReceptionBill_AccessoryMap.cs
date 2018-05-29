using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_ReceptionBill_AccessoryMap : EntityTypeConfiguration<Qp_ReceptionBill_Accessory>
    {
        public Qp_ReceptionBill_AccessoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Items)
                .HasMaxLength(100);

            this.Property(t => t.OtherAccessory)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Qp_ReceptionBill_Accessory");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Items).HasColumnName("Items");
            this.Property(t => t.OtherAccessory).HasColumnName("OtherAccessory");
        }
    }
}
