using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class WeighBeamConfigMap : EntityTypeConfiguration<WeighBeamConfig>
    {
        public WeighBeamConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RecogniseAmount, t.RecogniseCode, t.CodingAmount, t.PriceAmount, t.WeightAmount });

            // Properties
            this.Property(t => t.RecogniseAmount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RecogniseCode)
                .IsRequired()
                .HasMaxLength(120);

            this.Property(t => t.CodingAmount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriceAmount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WeightAmount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("WeighBeamConfig");
            this.Property(t => t.RecogniseAmount).HasColumnName("RecogniseAmount");
            this.Property(t => t.RecogniseCode).HasColumnName("RecogniseCode");
            this.Property(t => t.CodingAmount).HasColumnName("CodingAmount");
            this.Property(t => t.PriceAmount).HasColumnName("PriceAmount");
            this.Property(t => t.WeightAmount).HasColumnName("WeightAmount");
            this.Property(t => t.XiaoYanAmount).HasColumnName("XiaoYanAmount");
        }
    }
}
