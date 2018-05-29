using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_AttachmentMap : EntityTypeConfiguration<OA_Attachment>
    {
        public OA_AttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(20);

            this.Property(t => t.ETypeID_CreatorTypeID)
                .HasMaxLength(50);

            this.Property(t => t.FileName)
                .HasMaxLength(200);

            this.Property(t => t.ContentType)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OA_Attachment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FatherID).HasColumnName("FatherID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ETypeID_CreatorTypeID).HasColumnName("ETypeID_CreatorTypeID");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.ContentType).HasColumnName("ContentType");
            this.Property(t => t.FileSize).HasColumnName("FileSize");
            this.Property(t => t.BinaryData).HasColumnName("BinaryData");
        }
    }
}
