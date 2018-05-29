using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_PrivateDBMap : EntityTypeConfiguration<OA_PrivateDB>
    {
        public OA_PrivateDBMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.AttachmentID, t.IsRead, t.Docking, t.SortOrder });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.CatalogID)
                .HasMaxLength(30);

            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.Content)
                .HasMaxLength(8000);

            this.Property(t => t.ETypeID_SenderTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID_ReceiverTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID_CreatorTypeID)
                .HasMaxLength(50);

            this.Property(t => t.AttachmentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsRead)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Type)
                .HasMaxLength(20);

            this.Property(t => t.Docking)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SortOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OA_PrivateDB");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CatalogID).HasColumnName("CatalogID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.ETypeID_SenderTypeID).HasColumnName("ETypeID_SenderTypeID");
            this.Property(t => t.ETypeID_ReceiverTypeID).HasColumnName("ETypeID_ReceiverTypeID");
            this.Property(t => t.ETypeID_CreatorTypeID).HasColumnName("ETypeID_CreatorTypeID");
            this.Property(t => t.AttachmentID).HasColumnName("AttachmentID");
            this.Property(t => t.IsRead).HasColumnName("IsRead");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Docking).HasColumnName("Docking");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");
        }
    }
}
