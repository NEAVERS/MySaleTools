using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sp_sysReportConditionMap : EntityTypeConfiguration<sp_sysReportCondition>
    {
        public sp_sysReportConditionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.funName)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sp_sysReportCondition");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.sp_Id).HasColumnName("sp_Id");
            this.Property(t => t.funName).HasColumnName("funName");
            this.Property(t => t.orderId).HasColumnName("orderId");
            this.Property(t => t.sortId).HasColumnName("sortId");
        }
    }
}
