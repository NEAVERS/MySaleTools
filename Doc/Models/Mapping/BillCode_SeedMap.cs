using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BillCode_SeedMap : EntityTypeConfiguration<BillCode_Seed>
    {
        public BillCode_SeedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.C_ID, t.BillType, t.STypeID, t.KTypeID, t.ETypeID, t.FlowDate, t.Seed, t.DTypeId });

            // Properties
            this.Property(t => t.C_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FlowDate)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Seed)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DTypeId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BillCode_Seed");
            this.Property(t => t.C_ID).HasColumnName("_ID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.FlowDate).HasColumnName("FlowDate");
            this.Property(t => t.Seed).HasColumnName("Seed");
            this.Property(t => t.DTypeId).HasColumnName("DTypeId");
        }
    }
}
