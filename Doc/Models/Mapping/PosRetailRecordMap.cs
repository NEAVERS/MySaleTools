using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosRetailRecordMap : EntityTypeConfiguration<PosRetailRecord>
    {
        public PosRetailRecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.PosSaleBillId, t.PosBillNumberId, t.RetailBillId, t.RetailBillNumberId, t.AuditingFlag });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PosSaleBillId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PosBillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RetailBillId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RetailBillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosRetailRecord");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PosSaleBillId).HasColumnName("PosSaleBillId");
            this.Property(t => t.PosBillNumberId).HasColumnName("PosBillNumberId");
            this.Property(t => t.RetailBillId).HasColumnName("RetailBillId");
            this.Property(t => t.RetailBillNumberId).HasColumnName("RetailBillNumberId");
            this.Property(t => t.AuditingFlag).HasColumnName("AuditingFlag");
            this.Property(t => t.RecordTime).HasColumnName("RecordTime");
        }
    }
}
