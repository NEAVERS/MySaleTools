using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_ReceptionBill_PicMap : EntityTypeConfiguration<Qp_ReceptionBill_Pic>
    {
        public Qp_ReceptionBill_PicMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ImgPoint)
                .HasMaxLength(6000);

            // Table & Column Mappings
            this.ToTable("Qp_ReceptionBill_Pic");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Pic).HasColumnName("Pic");
            this.Property(t => t.ImgPoint).HasColumnName("ImgPoint");
        }
    }
}
