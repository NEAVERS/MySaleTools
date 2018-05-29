using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_ReceptionBill_InsuranceMap : EntityTypeConfiguration<Qp_ReceptionBill_Insurance>
    {
        public Qp_ReceptionBill_InsuranceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BTypeID)
                .HasMaxLength(50);

            this.Property(t => t.AccidentAddr)
                .HasMaxLength(1000);

            this.Property(t => t.AccidentReason)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Qp_ReceptionBill_Insurance");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.AccidentDate).HasColumnName("AccidentDate");
            this.Property(t => t.AccidentAddr).HasColumnName("AccidentAddr");
            this.Property(t => t.AccidentReason).HasColumnName("AccidentReason");
        }
    }
}
