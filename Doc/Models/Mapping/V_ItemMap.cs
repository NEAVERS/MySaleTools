using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class V_ItemMap : EntityTypeConfiguration<V_Item>
    {
        public V_ItemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.iscombined, t.itemid });

            // Properties
            this.Property(t => t.iscombined)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.itemid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("V_Item");
            this.Property(t => t.iscombined).HasColumnName("iscombined");
            this.Property(t => t.itemid).HasColumnName("itemid");
            this.Property(t => t.itemname).HasColumnName("itemname");
        }
    }
}
