using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BarCodeForBilltypeMap : EntityTypeConfiguration<BarCodeForBilltype>
    {
        public BarCodeForBilltypeMap()
        {
            // Primary Key
            this.HasKey(t => t.BillType);

            // Properties
            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BarCodeForBilltype");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.BarCodeID).HasColumnName("BarCodeID");
        }
    }
}
