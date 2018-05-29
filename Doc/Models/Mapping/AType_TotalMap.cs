using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AType_TotalMap : EntityTypeConfiguration<AType_Total>
    {
        public AType_TotalMap()
        {
            // Primary Key
            this.HasKey(t => t.ATypeID);

            // Properties
            this.Property(t => t.ATypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AType_Total");
            this.Property(t => t.ATypeID).HasColumnName("ATypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.Total00).HasColumnName("Total00");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.Ntotal00).HasColumnName("Ntotal00");
            this.Property(t => t.Ntotal).HasColumnName("Ntotal");
        }
    }
}
