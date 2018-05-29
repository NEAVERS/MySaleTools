using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class distributingshowformatMap : EntityTypeConfiguration<distributingshowformat>
    {
        public distributingshowformatMap()
        {
            // Primary Key
            this.HasKey(t => t.value);

            // Properties
            this.Property(t => t.value)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("distributingshowformat");
            this.Property(t => t.value).HasColumnName("value");
        }
    }
}
