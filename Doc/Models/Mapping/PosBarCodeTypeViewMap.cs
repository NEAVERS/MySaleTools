using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosBarCodeTypeViewMap : EntityTypeConfiguration<PosBarCodeTypeView>
    {
        public PosBarCodeTypeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.bartypeid, t.BarCheckDigit, t.IsStoped, t.IsDeleted, t.iBYZD });

            // Properties
            this.Property(t => t.bartypeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BarName)
                .HasMaxLength(30);

            this.Property(t => t.DisplayBarName)
                .HasMaxLength(30);

            this.Property(t => t.BarCheckDigit)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsStoped)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsDeleted)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cBYZD)
                .HasMaxLength(30);

            this.Property(t => t.iBYZD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosBarCodeTypeView");
            this.Property(t => t.bartypeid).HasColumnName("bartypeid");
            this.Property(t => t.BarName).HasColumnName("BarName");
            this.Property(t => t.DisplayBarName).HasColumnName("DisplayBarName");
            this.Property(t => t.BarCheckDigit).HasColumnName("BarCheckDigit");
            this.Property(t => t.IsStoped).HasColumnName("IsStoped");
            this.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            this.Property(t => t.cBYZD).HasColumnName("cBYZD");
            this.Property(t => t.iBYZD).HasColumnName("iBYZD");
        }
    }
}
