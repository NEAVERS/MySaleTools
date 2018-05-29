using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosDataUpdatedMap : EntityTypeConfiguration<PosDataUpdated>
    {
        public PosDataUpdatedMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.UpdateDataList)
                .HasMaxLength(1000);

            this.Property(t => t.AllDataList)
                .HasMaxLength(1000);

            this.Property(t => t.stypeid)
                .HasMaxLength(50);

            this.Property(t => t.folder)
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("PosDataUpdated");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UpdateDateTime).HasColumnName("UpdateDateTime");
            this.Property(t => t.UpdateDataList).HasColumnName("UpdateDataList");
            this.Property(t => t.AllDataList).HasColumnName("AllDataList");
            this.Property(t => t.stypeid).HasColumnName("stypeid");
            this.Property(t => t.folder).HasColumnName("folder");
        }
    }
}
