using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class EtypeSaleAllPlanMap : EntityTypeConfiguration<EtypeSaleAllPlan>
    {
        public EtypeSaleAllPlanMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FullName)
                .HasMaxLength(400);

            this.Property(t => t.Comment)
                .HasMaxLength(800);

            this.Property(t => t.MoneyUnit)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EtypeSaleAllPlan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.TotalID).HasColumnName("TotalID");
            this.Property(t => t.DTypePlanID).HasColumnName("DTypePlanID");
            this.Property(t => t.AllPlanValue).HasColumnName("AllPlanValue");
            this.Property(t => t.AllRatingValue).HasColumnName("AllRatingValue");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IfAudit).HasColumnName("IfAudit");
            this.Property(t => t.IfUse).HasColumnName("IfUse");
            this.Property(t => t.MoneyUnit).HasColumnName("MoneyUnit");
        }
    }
}
