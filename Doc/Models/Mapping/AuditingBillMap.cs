using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AuditingBillMap : EntityTypeConfiguration<AuditingBill>
    {
        public AuditingBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.AuditingID, t.IfAudit });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditingSteps)
                .HasMaxLength(50);

            this.Property(t => t.IfAudit)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.BillCode)
                .HasMaxLength(200);

            this.Property(t => t.BillIndexType)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PassSteps)
                .HasMaxLength(50);

            this.Property(t => t.StepReasons)
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("AuditingBill");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.AuditingID).HasColumnName("AuditingID");
            this.Property(t => t.AuditingSteps).HasColumnName("AuditingSteps");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillDetail).HasColumnName("BillDetail");
            this.Property(t => t.BillIndexType).HasColumnName("BillIndexType");
            this.Property(t => t.PassSteps).HasColumnName("PassSteps");
            this.Property(t => t.StepReasons).HasColumnName("StepReasons");
        }
    }
}
