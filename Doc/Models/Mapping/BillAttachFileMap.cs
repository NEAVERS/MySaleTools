using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillAttachFileMap : EntityTypeConfiguration<BillAttachFile>
    {
        public BillAttachFileMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FileName)
                .HasMaxLength(300);

            this.Property(t => t.FileType)
                .HasMaxLength(50);

            this.Property(t => t.Size)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.BillGuid)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BillAttachFiles");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.AttachDate).HasColumnName("AttachDate");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.BillIndexType).HasColumnName("BillIndexType");
            this.Property(t => t.BillGuid).HasColumnName("BillGuid");
            this.Property(t => t.BillType).HasColumnName("BillType");
        }
    }
}
