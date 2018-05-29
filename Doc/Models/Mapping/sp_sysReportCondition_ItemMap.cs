using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sp_sysReportCondition_ItemMap : EntityTypeConfiguration<sp_sysReportCondition_Item>
    {
        public sp_sysReportCondition_ItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.paramValue)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("sp_sysReportCondition_Item");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.sp_Id).HasColumnName("sp_Id");
            this.Property(t => t.orderId).HasColumnName("orderId");
            this.Property(t => t.paramValue).HasColumnName("paramValue");
        }
    }
}
