using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OMBillShipmentMap : EntityTypeConfiguration<OMBillShipment>
    {
        public OMBillShipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.comment)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("OMBillShipments");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OMBillID).HasColumnName("OMBillID");
            this.Property(t => t.GoodsBillID).HasColumnName("GoodsBillID");
            this.Property(t => t.ReachQty).HasColumnName("ReachQty");
            this.Property(t => t.ConfirmQty).HasColumnName("ConfirmQty");
            this.Property(t => t.STATUS).HasColumnName("STATUS");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
