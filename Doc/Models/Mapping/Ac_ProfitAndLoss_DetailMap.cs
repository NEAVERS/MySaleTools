using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_ProfitAndLoss_DetailMap : EntityTypeConfiguration<Ac_ProfitAndLoss_Detail>
    {
        public Ac_ProfitAndLoss_DetailMap()
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

            this.Property(t => t.FieldValue)
                .HasMaxLength(50);

            this.Property(t => t.FYear)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Ac_ProfitAndLoss_Detail");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.Ascids).HasColumnName("Ascids");
            this.Property(t => t.FieldValue).HasColumnName("FieldValue");
            this.Property(t => t.FFTotal).HasColumnName("FFTotal");
            this.Property(t => t.FFTotalFor).HasColumnName("FFTotalFor");
            this.Property(t => t.FYTotal).HasColumnName("FYTotal");
            this.Property(t => t.FYTotalFor).HasColumnName("FYTotalFor");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
        }
    }
}
