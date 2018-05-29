using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DocFileMap : EntityTypeConfiguration<DocFile>
    {
        public DocFileMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.pathId, t.FullName, t.FileSize, t.FileType, t.Binarydata, t.UploadDate, t.etypeid });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.pathId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FileSize)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FileType)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Binarydata)
                .IsRequired();

            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.xpsFileName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DocFile");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.pathId).HasColumnName("pathId");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.FileType).HasColumnName("FileType");
            this.Property(t => t.Binarydata).HasColumnName("Binarydata");
            this.Property(t => t.UploadDate).HasColumnName("UploadDate");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.xpsFileName).HasColumnName("xpsFileName");
        }
    }
}
