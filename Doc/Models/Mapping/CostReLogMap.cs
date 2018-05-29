using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CostReLogMap : EntityTypeConfiguration<CostReLog>
    {
        public CostReLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            this.Property(t => t.OperatorID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CostReLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.PostTime).HasColumnName("PostTime");
            this.Property(t => t.OperatorID).HasColumnName("OperatorID");
            this.Property(t => t.DealTime).HasColumnName("DealTime");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillType).HasColumnName("BillType");
        }
    }
}
