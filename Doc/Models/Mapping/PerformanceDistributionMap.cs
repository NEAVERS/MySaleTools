using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PerformanceDistributionMap : EntityTypeConfiguration<PerformanceDistribution>
    {
        public PerformanceDistributionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.IsPtype });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.IsPtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillComment)
                .HasMaxLength(500);

            this.Property(t => t.pid)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("PerformanceDistribution");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.Proportion).HasColumnName("Proportion");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.DiscountTotal).HasColumnName("DiscountTotal");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.IsPtype).HasColumnName("IsPtype");
            this.Property(t => t.BillComment).HasColumnName("BillComment");
            this.Property(t => t.pid).HasColumnName("pid");
        }
    }
}
