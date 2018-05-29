using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillAttachFilesLogMap : EntityTypeConfiguration<BillAttachFilesLog>
    {
        public BillAttachFilesLogMap()
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

            this.Property(t => t.logtype)
                .HasMaxLength(20);

            this.Property(t => t.FileName)
                .HasMaxLength(300);

            this.Property(t => t.FileSize)
                .HasMaxLength(100);

            this.Property(t => t.FileComment)
                .HasMaxLength(500);

            this.Property(t => t.FileUpEtype)
                .HasMaxLength(100);

            this.Property(t => t.BillGuid)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BillAttachFilesLog");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OperateDate).HasColumnName("OperateDate");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.logtype).HasColumnName("logtype");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.FileComment).HasColumnName("FileComment");
            this.Property(t => t.FileUpEtype).HasColumnName("FileUpEtype");
            this.Property(t => t.FileUpTime).HasColumnName("FileUpTime");
            this.Property(t => t.BillGuid).HasColumnName("BillGuid");
            this.Property(t => t.BillIndexType).HasColumnName("BillIndexType");
            this.Property(t => t.BillType).HasColumnName("BillType");
        }
    }
}
