using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class MenuTemplateConfigMap : EntityTypeConfiguration<MenuTemplateConfig>
    {
        public MenuTemplateConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NId, t.MenuID, t.Caption, t.Name });

            // Properties
            this.Property(t => t.NId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.MenuID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Caption)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MenuTemplateConfig");
            this.Property(t => t.NId).HasColumnName("NId");
            this.Property(t => t.MenuID).HasColumnName("MenuID");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IsChecked).HasColumnName("IsChecked");
        }
    }
}
