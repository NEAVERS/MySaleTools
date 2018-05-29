using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UFO_ReportCategoryMap : EntityTypeConfiguration<UFO_ReportCategory>
    {
        public UFO_ReportCategoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.TypeId, t.Name });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ParentTypeId)
                .HasMaxLength(50);

            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UFO_ReportCategory");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ParentTypeId).HasColumnName("ParentTypeId");
            this.Property(t => t.SysType).HasColumnName("SysType");
            this.Property(t => t.IsShares).HasColumnName("IsShares");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
        }
    }
}
