using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class KinOutStockConfigMap : EntityTypeConfiguration<KinOutStockConfig>
    {
        public KinOutStockConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ETypeId)
                .HasMaxLength(200);

            this.Property(t => t.BillTypes)
                .HasMaxLength(200);

            this.Property(t => t.Shownqty)
                .HasMaxLength(10);

            this.Property(t => t.Showinstock)
                .HasMaxLength(10);

            this.Property(t => t.Showoutstock)
                .HasMaxLength(10);

            this.Property(t => t.Showstock)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("KinOutStockConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.BillTypes).HasColumnName("BillTypes");
            this.Property(t => t.Shownqty).HasColumnName("Shownqty");
            this.Property(t => t.Showinstock).HasColumnName("Showinstock");
            this.Property(t => t.Showoutstock).HasColumnName("Showoutstock");
            this.Property(t => t.Showstock).HasColumnName("Showstock");
        }
    }
}
