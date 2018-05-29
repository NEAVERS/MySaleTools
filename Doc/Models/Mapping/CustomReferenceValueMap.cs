using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CustomReferenceValueMap : EntityTypeConfiguration<CustomReferenceValue>
    {
        public CustomReferenceValueMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.itemsid, t.ReferenId, t.PosDataVersion });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.itemsid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReferenId)
                .IsRequired();

            this.Property(t => t.PosDataVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("CustomReferenceValue");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.itemsid).HasColumnName("itemsid");
            this.Property(t => t.ReferenId).HasColumnName("ReferenId");
            this.Property(t => t.Fullname).HasColumnName("Fullname");
            this.Property(t => t.PosDataVersion).HasColumnName("PosDataVersion");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
        }
    }
}
