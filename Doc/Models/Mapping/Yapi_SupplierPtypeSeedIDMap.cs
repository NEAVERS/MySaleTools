using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Yapi_SupplierPtypeSeedIDMap : EntityTypeConfiguration<Yapi_SupplierPtypeSeedID>
    {
        public Yapi_SupplierPtypeSeedIDMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Yapi_SupplierPtypeSeedID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.SeedID).HasColumnName("SeedID");
        }
    }
}
