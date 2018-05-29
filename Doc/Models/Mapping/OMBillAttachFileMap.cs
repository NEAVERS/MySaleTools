using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OMBillAttachFileMap : EntityTypeConfiguration<OMBillAttachFile>
    {
        public OMBillAttachFileMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.BillNumberId, t.FileName, t.FileType, t.Size, t.AttachDate, t.Data, t.BillIndexType, t.bid });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.FileType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Size)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.newname)
                .HasMaxLength(100);

            this.Property(t => t.Data)
                .IsRequired();

            this.Property(t => t.BillIndexType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.operatorname)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OMBillAttachFiles");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.AttachDate).HasColumnName("AttachDate");
            this.Property(t => t.newname).HasColumnName("newname");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.BillIndexType).HasColumnName("BillIndexType");
            this.Property(t => t.bid).HasColumnName("bid");
            this.Property(t => t.operatorname).HasColumnName("operatorname");
        }
    }
}
