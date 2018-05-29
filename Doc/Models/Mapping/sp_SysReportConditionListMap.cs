using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sp_SysReportConditionListMap : EntityTypeConfiguration<sp_SysReportConditionList>
    {
        public sp_SysReportConditionListMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.funName)
                .HasMaxLength(50);

            this.Property(t => t.funExplain)
                .HasMaxLength(256);

            this.Property(t => t.funExample)
                .HasMaxLength(256);

            this.Property(t => t.paramExplain)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sp_SysReportConditionList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.funName).HasColumnName("funName");
            this.Property(t => t.funExplain).HasColumnName("funExplain");
            this.Property(t => t.funExample).HasColumnName("funExample");
            this.Property(t => t.paramExplain).HasColumnName("paramExplain");
            this.Property(t => t.paramCount).HasColumnName("paramCount");
        }
    }
}
