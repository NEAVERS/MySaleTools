using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class WebMenuMap : EntityTypeConfiguration<WebMenu>
    {
        public WebMenuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SysID, t.MenuID, t.IsRoot, t.IsSubMenu, t.Tabord, t.Caption, t.Name, t.AllUser, t.CallType, t.Offset });

            // Properties
            this.Property(t => t.SysID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MenuID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Tabord)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Caption)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CallType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.Offset)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.img)
                .HasMaxLength(100);

            this.Property(t => t.ShortCut)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("WebMenu");
            this.Property(t => t.SysID).HasColumnName("SysID");
            this.Property(t => t.MenuID).HasColumnName("MenuID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.IsRoot).HasColumnName("IsRoot");
            this.Property(t => t.IsSubMenu).HasColumnName("IsSubMenu");
            this.Property(t => t.Tabord).HasColumnName("Tabord");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AllUser).HasColumnName("AllUser");
            this.Property(t => t.CallType).HasColumnName("CallType");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Offset).HasColumnName("Offset");
            this.Property(t => t.img).HasColumnName("img");
            this.Property(t => t.ShortCut).HasColumnName("ShortCut");
        }
    }
}
