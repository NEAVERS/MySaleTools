using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ImportPtypeTemp1Map : EntityTypeConfiguration<ImportPtypeTemp1>
    {
        public ImportPtypeTemp1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.etypeid, t.BillType, t.PtypeId });

            // Properties
            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillType)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.PtypeId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ImportPtypeTemp1");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
        }
    }
}
