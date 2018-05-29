using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_Inventory_ExtMap : EntityTypeConfiguration<OM_Inventory_Ext>
    {
        public OM_Inventory_ExtMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.PtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CreatorName)
                .HasMaxLength(200);

            this.Property(t => t.ModifierName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OM_Inventory_Ext");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.InventoryId).HasColumnName("InventoryId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.CreatorId).HasColumnName("CreatorId");
            this.Property(t => t.CreatorName).HasColumnName("CreatorName");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.ModifierId).HasColumnName("ModifierId");
            this.Property(t => t.ModifierName).HasColumnName("ModifierName");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
        }
    }
}
