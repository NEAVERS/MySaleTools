using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_AttemperBill_RepairItemsPersonMap : EntityTypeConfiguration<Qp_AttemperBill_RepairItemsPerson>
    {
        public Qp_AttemperBill_RepairItemsPersonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Qp_AttemperBill_RepairItemsPerson");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairItemsID).HasColumnName("RepairItemsID");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.AllocateDate).HasColumnName("AllocateDate");
            this.Property(t => t.AllocateHour).HasColumnName("AllocateHour");
            this.Property(t => t.CheckHour).HasColumnName("CheckHour");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
        }
    }
}
