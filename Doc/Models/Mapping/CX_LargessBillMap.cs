using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CX_LargessBillMap : EntityTypeConfiguration<CX_LargessBill>
    {
        public CX_LargessBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.Row, t.LargessRow });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Row)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LargessRow)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LargessPtypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CX_LargessBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Row).HasColumnName("Row");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.LargessRow).HasColumnName("LargessRow");
            this.Property(t => t.LargessPtypeId).HasColumnName("LargessPtypeId");
            this.Property(t => t.LargessAddTotal).HasColumnName("LargessAddTotal");
            this.Property(t => t.LargessQty).HasColumnName("LargessQty");
        }
    }
}
