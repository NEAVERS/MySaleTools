using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class visitfjMap : EntityTypeConfiguration<visitfj>
    {
        public visitfjMap()
        {
            // Primary Key
            this.HasKey(t => new { t.billnumberid, t.filename, t.filesize, t.filetype, t.binarydata, t.etypeid, t.filename1 });

            // Properties
            this.Property(t => t.billnumberid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.filename)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.filesize)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.filetype)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.binarydata)
                .IsRequired();

            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.filename1)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("visitfj");
            this.Property(t => t.billnumberid).HasColumnName("billnumberid");
            this.Property(t => t.filename).HasColumnName("filename");
            this.Property(t => t.filesize).HasColumnName("filesize");
            this.Property(t => t.filetype).HasColumnName("filetype");
            this.Property(t => t.binarydata).HasColumnName("binarydata");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.filename1).HasColumnName("filename1");
        }
    }
}
