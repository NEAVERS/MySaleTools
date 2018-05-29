using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class cityMap : EntityTypeConfiguration<city>
    {
        public cityMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Cname)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("city");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.areaid).HasColumnName("areaid");
            this.Property(t => t.Cname).HasColumnName("Cname");
            this.Property(t => t.orderid).HasColumnName("orderid");
        }
    }
}
