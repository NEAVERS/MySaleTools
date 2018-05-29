using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class xw_AttachmentMap : EntityTypeConfiguration<xw_Attachment>
    {
        public xw_AttachmentMap()
        {
            // Primary Key
            this.HasKey(t => t.C_Id);

            // Properties
            this.Property(t => t.Content)
                .IsRequired();

            this.Property(t => t.Filename)
                .HasMaxLength(255);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("xw_Attachment");
            this.Property(t => t.C_Id).HasColumnName("_Id");
            this.Property(t => t.Guid).HasColumnName("Guid");
            this.Property(t => t.OwnerGuid).HasColumnName("OwnerGuid");
            this.Property(t => t.OwnerId).HasColumnName("OwnerId");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Filename).HasColumnName("Filename");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.CreationTime).HasColumnName("CreationTime");
            this.Property(t => t.LastModifiedTime).HasColumnName("LastModifiedTime");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
