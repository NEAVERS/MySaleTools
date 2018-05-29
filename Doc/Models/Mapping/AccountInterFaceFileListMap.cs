using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AccountInterFaceFileListMap : EntityTypeConfiguration<AccountInterFaceFileList>
    {
        public AccountInterFaceFileListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FileID, t.FileName, t.CreateDate });

            // Properties
            this.Property(t => t.FileID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.ContentType)
                .HasMaxLength(100);

            this.Property(t => t.Memo)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AccountInterFaceFileList");
            this.Property(t => t.FileID).HasColumnName("FileID");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.ContentType).HasColumnName("ContentType");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.BinaryData).HasColumnName("BinaryData");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}
