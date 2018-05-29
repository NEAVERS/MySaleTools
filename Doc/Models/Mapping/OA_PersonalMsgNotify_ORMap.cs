using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_PersonalMsgNotify_ORMap : EntityTypeConfiguration<OA_PersonalMsgNotify_OR>
    {
        public OA_PersonalMsgNotify_ORMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ModifyDate, t.Available });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeID_CreatorTypeID)
                .HasMaxLength(50);

            this.Property(t => t.CatalogTypeID)
                .HasMaxLength(30);

            this.Property(t => t.PublisherTypeID)
                .HasMaxLength(2000);

            this.Property(t => t.PublisherName)
                .HasMaxLength(2000);

            this.Property(t => t.Content)
                .HasMaxLength(2000);

            this.Property(t => t.Available)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Grammar)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("OA_PersonalMsgNotify_OR");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeID_CreatorTypeID).HasColumnName("ETypeID_CreatorTypeID");
            this.Property(t => t.CatalogTypeID).HasColumnName("CatalogTypeID");
            this.Property(t => t.PublisherTypeID).HasColumnName("PublisherTypeID");
            this.Property(t => t.PublisherName).HasColumnName("PublisherName");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.ModifyDate).HasColumnName("ModifyDate");
            this.Property(t => t.Available).HasColumnName("Available");
            this.Property(t => t.Grammar).HasColumnName("Grammar");
        }
    }
}
