using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class EshopBaseInfoMap : EntityTypeConfiguration<EshopBaseInfo>
    {
        public EshopBaseInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Field)
                .HasMaxLength(50);

            this.Property(t => t.EshopID)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("EshopBaseInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Field).HasColumnName("Field");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.EshopID).HasColumnName("EshopID");
        }
    }
}
