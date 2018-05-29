using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Yapi_BillSeedIDMap : EntityTypeConfiguration<Yapi_BillSeedID>
    {
        public Yapi_BillSeedIDMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.billtype });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("Yapi_BillSeedID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.billtype).HasColumnName("billtype");
            this.Property(t => t.SeedID).HasColumnName("SeedID");
        }
    }
}
