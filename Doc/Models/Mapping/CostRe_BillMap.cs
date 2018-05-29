using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CostRe_BillMap : EntityTypeConfiguration<CostRe_Bill>
    {
        public CostRe_BillMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CostRe_Bill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.PostTime).HasColumnName("PostTime");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
        }
    }
}
