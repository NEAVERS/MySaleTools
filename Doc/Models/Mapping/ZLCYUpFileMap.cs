using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ZLCYUpFileMap : EntityTypeConfiguration<ZLCYUpFile>
    {
        public ZLCYUpFileMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BBSID)
                .HasMaxLength(25);

            this.Property(t => t.FileName)
                .HasMaxLength(256);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.ContentType)
                .HasMaxLength(100);

            this.Property(t => t.szDate)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ZLCYUpFiles");
            this.Property(t => t.BBSID).HasColumnName("BBSID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.BinaryContent).HasColumnName("BinaryContent");
            this.Property(t => t.ContentType).HasColumnName("ContentType");
            this.Property(t => t.ContentLength).HasColumnName("ContentLength");
            this.Property(t => t.szDate).HasColumnName("szDate");
        }
    }
}
