using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AuditingBillDetailMap : EntityTypeConfiguration<AuditingBillDetail>
    {
        public AuditingBillDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberID, t.ETypeID, t.AuditingDate, t.AuditingFlag, t.AuditingStep });

            // Properties
            this.Property(t => t.BillNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuditingExplain)
                .HasMaxLength(255);

            this.Property(t => t.AuditingFlag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AuditingStep)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillIndexType)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("AuditingBillDetail");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.AuditingExplain).HasColumnName("AuditingExplain");
            this.Property(t => t.AuditingDate).HasColumnName("AuditingDate");
            this.Property(t => t.AuditingFlag).HasColumnName("AuditingFlag");
            this.Property(t => t.AuditingStep).HasColumnName("AuditingStep");
            this.Property(t => t.BillIndexType).HasColumnName("BillIndexType");
        }
    }
}
