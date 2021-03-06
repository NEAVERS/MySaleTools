using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DtypeSaleplanMap : EntityTypeConfiguration<DtypeSaleplan>
    {
        public DtypeSaleplanMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DtypeID)
                .HasMaxLength(50);

            this.Property(t => t.StypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DtypeSaleplan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DplanID).HasColumnName("DplanID");
            this.Property(t => t.DtypeID).HasColumnName("DtypeID");
            this.Property(t => t.TimeID).HasColumnName("TimeID");
            this.Property(t => t.StypeID).HasColumnName("StypeID");
            this.Property(t => t.RatingValue).HasColumnName("RatingValue");
            this.Property(t => t.PlanValue).HasColumnName("PlanValue");
            this.Property(t => t.ApportionScale).HasColumnName("ApportionScale");
        }
    }
}
