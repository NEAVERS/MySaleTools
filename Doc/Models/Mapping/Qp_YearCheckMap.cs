using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_YearCheckMap : EntityTypeConfiguration<Qp_YearCheck>
    {
        public Qp_YearCheckMap()
        {
            // Primary Key
            this.HasKey(t => t.YearCheckId);

            // Properties
            this.Property(t => t.RaTypeID)
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            this.Property(t => t.YearCheckNo)
                .HasMaxLength(250);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.Mobile)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Qp_YearCheck");
            this.Property(t => t.YearCheckId).HasColumnName("YearCheckId");
            this.Property(t => t.RaTypeID).HasColumnName("RaTypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.YearCheckNo).HasColumnName("YearCheckNo");
            this.Property(t => t.YearCheckTotal).HasColumnName("YearCheckTotal");
            this.Property(t => t.YearCheckDate).HasColumnName("YearCheckDate");
            this.Property(t => t.ReachDate).HasColumnName("ReachDate");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
        }
    }
}
