using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_DepreciationPlanMap : EntityTypeConfiguration<Ac_DepreciationPlan>
    {
        public Ac_DepreciationPlanMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.DTypeid)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.DisATypeId)
                .HasMaxLength(50);

            this.Property(t => t.WorkUnit)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_DepreciationPlan");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.DTypeid).HasColumnName("DTypeid");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.InAccountDate).HasColumnName("InAccountDate");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.DepreciationMean).HasColumnName("DepreciationMean");
            this.Property(t => t.YearOrder).HasColumnName("YearOrder");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.MonthOrder).HasColumnName("MonthOrder");
            this.Property(t => t.PlanType).HasColumnName("PlanType");
            this.Property(t => t.AssetCardId).HasColumnName("AssetCardId");
            this.Property(t => t.Depreciation).HasColumnName("Depreciation");
            this.Property(t => t.DepTotal).HasColumnName("DepTotal");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.DevalueReady).HasColumnName("DevalueReady");
            this.Property(t => t.NetValue).HasColumnName("NetValue");
            this.Property(t => t.NetSalvage).HasColumnName("NetSalvage");
            this.Property(t => t.PlanState).HasColumnName("PlanState");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DisATypeId).HasColumnName("DisATypeId");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ExpectWork).HasColumnName("ExpectWork");
            this.Property(t => t.FinishWork).HasColumnName("FinishWork");
            this.Property(t => t.WorkUnit).HasColumnName("WorkUnit");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
        }
    }
}
