using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillNameMap : EntityTypeConfiguration<BillName>
    {
        public BillNameMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Billtype, t.BillName1, t.Billtypes, t.BillNames });

            // Properties
            this.Property(t => t.Billtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillName1)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Billtypes)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.BillNames)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.detailTable)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BillName");
            this.Property(t => t.Billtype).HasColumnName("Billtype");
            this.Property(t => t.BillName1).HasColumnName("BillName");
            this.Property(t => t.Billtypes).HasColumnName("Billtypes");
            this.Property(t => t.BillNames).HasColumnName("BillNames");
            this.Property(t => t.SortId).HasColumnName("SortId");
            this.Property(t => t.detailTable).HasColumnName("detailTable");
        }
    }
}
