using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BType_ArApTotalMap : EntityTypeConfiguration<BType_ArApTotal>
    {
        public BType_ArApTotalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BTypeID, t.STypeID });

            // Properties
            this.Property(t => t.BTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BType_ArApTotal");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.ARTotal).HasColumnName("ARTotal");
            this.Property(t => t.APTotal).HasColumnName("APTotal");
            this.Property(t => t.YSTotal).HasColumnName("YSTotal");
            this.Property(t => t.YFTotal).HasColumnName("YFTotal");
            this.Property(t => t.ARTotal00).HasColumnName("ARTotal00");
            this.Property(t => t.APTotal00).HasColumnName("APTotal00");
            this.Property(t => t.YSTotal00).HasColumnName("YSTotal00");
            this.Property(t => t.YFTotal00).HasColumnName("YFTotal00");
            this.Property(t => t.nARTotal).HasColumnName("nARTotal");
            this.Property(t => t.nAPTotal).HasColumnName("nAPTotal");
            this.Property(t => t.nYSTotal).HasColumnName("nYSTotal");
            this.Property(t => t.nYFTotal).HasColumnName("nYFTotal");
            this.Property(t => t.nARTotal00).HasColumnName("nARTotal00");
            this.Property(t => t.nAPTotal00).HasColumnName("nAPTotal00");
            this.Property(t => t.nYSTotal00).HasColumnName("nYSTotal00");
            this.Property(t => t.nYFTotal00).HasColumnName("nYFTotal00");
            this.Property(t => t.CID).HasColumnName("CID");
            this.Property(t => t.GRIRTotal).HasColumnName("GRIRTotal");
            this.Property(t => t.NGRIRTotal).HasColumnName("NGRIRTotal");
            this.Property(t => t.GRIRTotal00).HasColumnName("GRIRTotal00");
            this.Property(t => t.NGRIRTotal00).HasColumnName("NGRIRTotal00");
            this.Property(t => t.FCTotal).HasColumnName("FCTotal");
            this.Property(t => t.NFCTotal).HasColumnName("NFCTotal");
            this.Property(t => t.FCTotal00).HasColumnName("FCTotal00");
            this.Property(t => t.NFCTotal00).HasColumnName("NFCTotal00");
        }
    }
}
