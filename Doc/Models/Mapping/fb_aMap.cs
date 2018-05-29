using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class fb_aMap : EntityTypeConfiguration<fb_a>
    {
        public fb_aMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("fb_a");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.A).HasColumnName("A");
        }
    }
}
