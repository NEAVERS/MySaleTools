using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_ItemIDByIsCombinedMap : EntityTypeConfiguration<vWeb_ItemIDByIsCombined>
    {
        public vWeb_ItemIDByIsCombinedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.iscombined, t.id, t.DataTypeId });

            // Properties
            this.Property(t => t.itemID)
                .HasMaxLength(12);

            this.Property(t => t.iscombined)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DataTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vWeb_ItemIDByIsCombined");
            this.Property(t => t.itemID).HasColumnName("itemID");
            this.Property(t => t.iscombined).HasColumnName("iscombined");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.DataTypeId).HasColumnName("DataTypeId");
        }
    }
}
