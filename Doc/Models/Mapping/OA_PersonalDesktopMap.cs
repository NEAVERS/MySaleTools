using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OA_PersonalDesktopMap : EntityTypeConfiguration<OA_PersonalDesktop>
    {
        public OA_PersonalDesktopMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.SortOrder, t.DesktopList, t.Notify, t.ReplyNotify, t.RefusePassiveReplyNotify });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeID_CreatorTypeID)
                .HasMaxLength(50);

            this.Property(t => t.CatalogTypeID)
                .HasMaxLength(30);

            this.Property(t => t.SortOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DesktopList)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notify)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReplyNotify)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RefusePassiveReplyNotify)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OA_PersonalDesktop");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeID_CreatorTypeID).HasColumnName("ETypeID_CreatorTypeID");
            this.Property(t => t.CatalogTypeID).HasColumnName("CatalogTypeID");
            this.Property(t => t.SortOrder).HasColumnName("SortOrder");
            this.Property(t => t.DesktopList).HasColumnName("DesktopList");
            this.Property(t => t.Notify).HasColumnName("Notify");
            this.Property(t => t.ReplyNotify).HasColumnName("ReplyNotify");
            this.Property(t => t.RefusePassiveReplyNotify).HasColumnName("RefusePassiveReplyNotify");
        }
    }
}
