using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ToolIndexMap : EntityTypeConfiguration<ToolIndex>
    {
        public ToolIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.BillCode)
                .HasMaxLength(200);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            this.Property(t => t.DTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Checke)
                .HasMaxLength(50);

            this.Property(t => t.Explain)
                .HasMaxLength(256);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.InOutType)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ToolIndex");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.DTypeID).HasColumnName("DTypeID");
            this.Property(t => t.Checke).HasColumnName("Checke");
            this.Property(t => t.Explain).HasColumnName("Explain");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.InOutType).HasColumnName("InOutType");
        }
    }
}
