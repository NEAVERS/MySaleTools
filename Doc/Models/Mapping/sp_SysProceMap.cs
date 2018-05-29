using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sp_SysProceMap : EntityTypeConfiguration<sp_SysProce>
    {
        public sp_SysProceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.sp_ReportName)
                .HasMaxLength(256);

            this.Property(t => t.sp_ProcName)
                .HasMaxLength(200);

            this.Property(t => t.hidd_Value)
                .HasMaxLength(200);

            this.Property(t => t.onClick)
                .HasMaxLength(200);

            this.Property(t => t.onDbClick)
                .HasMaxLength(200);

            this.Property(t => t.Height)
                .HasMaxLength(50);

            this.Property(t => t.Width)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("sp_SysProce");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.sp_ReportId).HasColumnName("sp_ReportId");
            this.Property(t => t.sp_ReportName).HasColumnName("sp_ReportName");
            this.Property(t => t.sp_ProcName).HasColumnName("sp_ProcName");
            this.Property(t => t.is_Tree).HasColumnName("is_Tree");
            this.Property(t => t.hidd_Value).HasColumnName("hidd_Value");
            this.Property(t => t.onClick).HasColumnName("onClick");
            this.Property(t => t.onDbClick).HasColumnName("onDbClick");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Width).HasColumnName("Width");
        }
    }
}
