using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class wx_StockTotalConfigMap : EntityTypeConfiguration<wx_StockTotalConfig>
    {
        public wx_StockTotalConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ETypeId)
                .HasMaxLength(200);

            this.Property(t => t.BillTypes)
                .HasMaxLength(200);

            this.Property(t => t.ShowBdPType)
                .HasMaxLength(10);

            this.Property(t => t.ShowSum)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("wx_StockTotalConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.BillTypes).HasColumnName("BillTypes");
            this.Property(t => t.ShowBdPType).HasColumnName("ShowBdPType");
            this.Property(t => t.ShowSum).HasColumnName("ShowSum");
        }
    }
}
