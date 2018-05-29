using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CX_LargessBillViewMap : EntityTypeConfiguration<CX_LargessBillView>
    {
        public CX_LargessBillViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.Row, t.PtypeId, t.LargessRow });

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
            this.ToTable("CX_LargessBillView");
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
