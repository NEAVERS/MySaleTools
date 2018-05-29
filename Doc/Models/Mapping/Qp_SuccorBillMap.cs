using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_SuccorBillMap : EntityTypeConfiguration<Qp_SuccorBill>
    {
        public Qp_SuccorBillMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LinkPerson)
                .HasMaxLength(100);

            this.Property(t => t.LinkTel)
                .HasMaxLength(100);

            this.Property(t => t.ServiceCardNo)
                .HasMaxLength(100);

            this.Property(t => t.SuccorAddr)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Qp_SuccorBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.LinkPerson).HasColumnName("LinkPerson");
            this.Property(t => t.LinkTel).HasColumnName("LinkTel");
            this.Property(t => t.ServiceCardNo).HasColumnName("ServiceCardNo");
            this.Property(t => t.SuccorAddr).HasColumnName("SuccorAddr");
            this.Property(t => t.SuccorId).HasColumnName("SuccorId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.ReachDate).HasColumnName("ReachDate");
            this.Property(t => t.ReturnDate).HasColumnName("ReturnDate");
        }
    }
}
