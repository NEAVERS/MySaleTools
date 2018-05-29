using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_SuccorBill_PTypeMap : EntityTypeConfiguration<Qp_SuccorBill_PType>
    {
        public Qp_SuccorBill_PTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.KTypeId)
                .HasMaxLength(50);

            this.Property(t => t.CargoSpace)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Qp_SuccorBill_PType");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.InputCostPrice).HasColumnName("InputCostPrice");
            this.Property(t => t.KTypeId).HasColumnName("KTypeId");
            this.Property(t => t.CargoSpace).HasColumnName("CargoSpace");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
        }
    }
}
