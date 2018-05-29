using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class v_getdateMap : EntityTypeConfiguration<v_getdate>
    {
        public v_getdateMap()
        {
            // Primary Key
            this.HasKey(t => t.output);

            // Properties
            // Table & Column Mappings
            this.ToTable("v_getdate");
            this.Property(t => t.output).HasColumnName("output");
        }
    }
}
