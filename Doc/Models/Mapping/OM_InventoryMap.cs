using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_InventoryMap : EntityTypeConfiguration<OM_Inventory>
    {
        public OM_InventoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.UserCode, t.FullName, t.Comment });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.CreatorName)
                .HasMaxLength(200);

            this.Property(t => t.ModifierName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OM_Inventory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.CreatorId).HasColumnName("CreatorId");
            this.Property(t => t.CreatorName).HasColumnName("CreatorName");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.ModifierId).HasColumnName("ModifierId");
            this.Property(t => t.ModifierName).HasColumnName("ModifierName");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
        }
    }
}
