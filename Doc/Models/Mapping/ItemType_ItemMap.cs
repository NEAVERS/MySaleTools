using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ItemType_ItemMap : EntityTypeConfiguration<ItemType_Item>
    {
        public ItemType_ItemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nId, t.itemTypeId, t.itemId });

            // Properties
            this.Property(t => t.nId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.itemTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.itemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ItemType_Item");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.itemTypeId).HasColumnName("itemTypeId");
            this.Property(t => t.itemId).HasColumnName("itemId");
        }
    }
}
