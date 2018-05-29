using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DepPlanBillMap : EntityTypeConfiguration<DepPlanBill>
    {
        public DepPlanBillMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("DepPlanBill");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlanId).HasColumnName("PlanId");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Month).HasColumnName("Month");
            this.Property(t => t.NDepMoney).HasColumnName("NDepMoney");
            this.Property(t => t.DepMoney).HasColumnName("DepMoney");
            this.Property(t => t.NDepTotal).HasColumnName("NDepTotal");
            this.Property(t => t.DepTotal).HasColumnName("DepTotal");
            this.Property(t => t.NNetValue).HasColumnName("NNetValue");
            this.Property(t => t.NetValue).HasColumnName("NetValue");
        }
    }
}
