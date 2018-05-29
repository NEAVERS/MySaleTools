using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_InsuranceAutoMap : EntityTypeConfiguration<Qp_InsuranceAuto>
    {
        public Qp_InsuranceAutoMap()
        {
            // Primary Key
            this.HasKey(t => t.InsuranceAutoId);

            // Properties
            this.Property(t => t.RaTypeID)
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            this.Property(t => t.InsuranceName)
                .HasMaxLength(500);

            this.Property(t => t.InsuranceNo)
                .HasMaxLength(250);

            this.Property(t => t.CardNumber)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            this.Property(t => t.Mobile)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Qp_InsuranceAuto");
            this.Property(t => t.InsuranceAutoId).HasColumnName("InsuranceAutoId");
            this.Property(t => t.RaTypeID).HasColumnName("RaTypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.InsuranceName).HasColumnName("InsuranceName");
            this.Property(t => t.InsuranceTotal).HasColumnName("InsuranceTotal");
            this.Property(t => t.ReachDate).HasColumnName("ReachDate");
            this.Property(t => t.InsuranceNo).HasColumnName("InsuranceNo");
            this.Property(t => t.CardNumber).HasColumnName("CardNumber");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
        }
    }
}
