using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_ProfitAndLossMap : EntityTypeConfiguration<Ac_ProfitAndLoss>
    {
        public Ac_ProfitAndLossMap()
        {
            // Primary Key
            this.HasKey(t => new { t.STypeId, t.ATypeId });

            // Properties
            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FYear)
                .HasMaxLength(10);

            this.Property(t => t.FPeriod)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Ac_ProfitAndLoss");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.FFTotal).HasColumnName("FFTotal");
            this.Property(t => t.FFTotalFor).HasColumnName("FFTotalFor");
            this.Property(t => t.FYTotal).HasColumnName("FYTotal");
            this.Property(t => t.FYTotalFor).HasColumnName("FYTotalFor");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
        }
    }
}
