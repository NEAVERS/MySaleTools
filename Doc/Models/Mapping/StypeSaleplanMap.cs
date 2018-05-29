using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class StypeSaleplanMap : EntityTypeConfiguration<StypeSaleplan>
    {
        public StypeSaleplanMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.StypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StypeSaleplan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SplanID).HasColumnName("SplanID");
            this.Property(t => t.StypeID).HasColumnName("StypeID");
            this.Property(t => t.RatingValue).HasColumnName("RatingValue");
            this.Property(t => t.PlanValue).HasColumnName("PlanValue");
            this.Property(t => t.ApportionScale).HasColumnName("ApportionScale");
            this.Property(t => t.TimeID).HasColumnName("TimeID");
        }
    }
}
