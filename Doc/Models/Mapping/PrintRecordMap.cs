using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PrintRecordMap : EntityTypeConfiguration<PrintRecord>
    {
        public PrintRecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillType, t.BillNumberId, t.etypeid, t.PrintTime, t.Ip, t.RecordState });

            // Properties
            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ip)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.eFullName)
                .HasMaxLength(150);

            this.Property(t => t.billcode)
                .HasMaxLength(200);

            this.Property(t => t.RecordState)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PrintRecord");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.PrintTime).HasColumnName("PrintTime");
            this.Property(t => t.Ip).HasColumnName("Ip");
            this.Property(t => t.PrintCount).HasColumnName("PrintCount");
            this.Property(t => t.eFullName).HasColumnName("eFullName");
            this.Property(t => t.BillState).HasColumnName("BillState");
            this.Property(t => t.billcode).HasColumnName("billcode");
            this.Property(t => t.RecordState).HasColumnName("RecordState");
        }
    }
}
